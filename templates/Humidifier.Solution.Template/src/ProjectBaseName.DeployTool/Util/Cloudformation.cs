using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Serilog;

namespace ProjectBaseName.DeployTool.Util
{
    public enum DeployStackResult
    {
        Ok,
        Failed,
        NoChanges
    }

    public static class Cloudformation
    {
        const string CAPABILITY_NAMED_IAM = "CAPABILITY_NAMED_IAM";
        const string IN_PROGRESS_SUFFIX = "IN_PROGRESS"; // CloudFormation statuses for when the stack is in transition all end with IN_PROGRESS

        static readonly TimeSpan POLLING_PERIOD = TimeSpan.FromSeconds(3);

        public static async Task<DeployStackResult> DeployStackAsync(ILogger log, IAmazonCloudFormation cloudformation, long ticks, string stackName, List<Tag> tags, Dictionary<string, string> parameters, string templateBody = null, Uri templateUrl = null, string roleArn = null)
        {
            log.Information("Checking stack: {stackName}", stackName);

            Stack existingStack = await GetExistingStackAsync(cloudformation, stackName).ConfigureAwait(false);
            log.Information("Found existing stack: " + (existingStack != null));

            var changeSetName = stackName + "-" + ticks;
            var param = parameters.Select(x => new Parameter { ParameterKey = x.Key, ParameterValue = x.Value }).ToList();

            // Determine if the stack is in a good state to be updated.
            ChangeSetType changeSetType;
            if (existingStack == null || existingStack.StackStatus == StackStatus.REVIEW_IN_PROGRESS || existingStack.StackStatus == StackStatus.DELETE_COMPLETE)
            {
                changeSetType = ChangeSetType.CREATE;
            }
            // If the state was ROLLBACK_COMPLETE that means the stack failed on initial creation and the resources where cleaned up. 
            // It is safe to delete the stack so we can recreate it.
            else if (existingStack.StackStatus == StackStatus.ROLLBACK_COMPLETE)
            {
                await DeleteRollbackCompleteStackAsync(log, cloudformation, existingStack).ConfigureAwait(false);
                changeSetType = ChangeSetType.CREATE;
            }
            // If the status was ROLLBACK_IN_PROGRESS that means the initial creation is failing.
            // Wait to see if it goes into ROLLBACK_COMPLETE status meaning everything got cleaned up and then delete it.
            else if (existingStack.StackStatus == StackStatus.ROLLBACK_IN_PROGRESS)
            {
                existingStack = await WaitForNoLongerInProgress(log, cloudformation, existingStack.StackName).ConfigureAwait(false);
                if (existingStack != null && existingStack.StackStatus == StackStatus.ROLLBACK_COMPLETE)
                {
                    await DeleteRollbackCompleteStackAsync(log, cloudformation, existingStack).ConfigureAwait(false);
                }

                changeSetType = ChangeSetType.CREATE;
            }
            // If the status was DELETE_IN_PROGRESS then just wait for delete to complete 
            else if (existingStack.StackStatus == StackStatus.DELETE_IN_PROGRESS)
            {
                await WaitForNoLongerInProgress(log, cloudformation, existingStack.StackName).ConfigureAwait(false);
                changeSetType = ChangeSetType.CREATE;
            }
            // The Stack state is in a normal state and ready to be updated.
            else if (existingStack.StackStatus == StackStatus.CREATE_COMPLETE ||
                     existingStack.StackStatus == StackStatus.UPDATE_COMPLETE ||
                     existingStack.StackStatus == StackStatus.UPDATE_ROLLBACK_COMPLETE)
            {
                changeSetType = ChangeSetType.UPDATE;
            }
            // All other states means the Stack is in an inconsistent state.
            else
            {
                log.Error($"The stack's current state of {existingStack.StackStatus} is invalid for updating");
                return DeployStackResult.Failed;
            }

            CreateChangeSetResponse changeSetResponse;
            try
            {
                var changeSetRequest = new CreateChangeSetRequest
                {
                    StackName = stackName,
                    ChangeSetName = changeSetName,
                    ChangeSetType = changeSetType,
                    Capabilities = new List<string> { CAPABILITY_NAMED_IAM },
                    Tags = tags,
                    Parameters = param,
                    RoleARN = roleArn
                };

                if (templateUrl != null)
                {
                    changeSetRequest.TemplateURL = templateUrl.ToString();
                }
                else
                {
                    changeSetRequest.TemplateBody = templateBody;
                }

                // Create the change set which performs the transformation on the Serverless resources in the template.
                changeSetResponse = await cloudformation.CreateChangeSetAsync(changeSetRequest).ConfigureAwait(false);
                log.Information("CloudFormation change set created. StackName: {stackName}, ChangeSetName: {changeSetName}", stackName, changeSetName);
            }
            catch (Exception e)
            {
                log.Error(e, "Error creating cloudformation change set");
                throw;
            }

            // The change set can take a few seconds to be reviewed and be ready to be executed.
            DeployStackResult waitResult = await WaitForChangeSetBeingAvailableAsync(log, cloudformation, changeSetResponse.Id).ConfigureAwait(false);
            if (waitResult == DeployStackResult.NoChanges || waitResult == DeployStackResult.Failed)
            {
                return waitResult;
            }

            var executeChangeSetRequest = new ExecuteChangeSetRequest
            {
                StackName = stackName,
                ChangeSetName = changeSetResponse.Id
            };

            // Execute the change set.
            var timeChangeSetExecuted = DateTime.Now;
            try
            {
                await cloudformation.ExecuteChangeSetAsync(executeChangeSetRequest).ConfigureAwait(false);
                if (changeSetType == ChangeSetType.CREATE)
                {
                    log.Information($"Created CloudFormation stack {stackName}");
                }
                else
                {
                    log.Information($"Initiated CloudFormation stack update on {stackName}");
                }
            }
            catch (Exception e)
            {
                log.Error(e, "Error executing cloudformation change set");
                throw;
            }

            // Wait for the stack to finish
            var updatedStack = await WaitStackToCompleteAsync(log, cloudformation, stackName, timeChangeSetExecuted).ConfigureAwait(false);
            if (updatedStack.StackStatus == StackStatus.CREATE_COMPLETE || updatedStack.StackStatus == StackStatus.UPDATE_COMPLETE)
            {
                log.Information($"Stack finished updating with status: {updatedStack.StackStatus}");

                // Display the output parameters.
                DisplayOutputs(log, updatedStack);
            }
            else
            {
                log.Error($"Stack update failed with status: {updatedStack.StackStatus} ({updatedStack.StackStatusReason})");
                return DeployStackResult.Failed;
            }

            return DeployStackResult.Ok;
        }

        private static async Task<Stack> WaitStackToCompleteAsync(ILogger log, IAmazonCloudFormation cloudformation, string stackName, DateTime mintimeStampForEvents)
        {
            const int TIMESTAMP_WIDTH = 20;
            const int LOGICAL_RESOURCE_WIDTH = 40;
            const int RESOURCE_STATUS = 40;

            var mostRecentEventId = "";

            log.Information("   ");
            log.Information(
                "Timestamp".PadRight(TIMESTAMP_WIDTH) + " " +
                "Logical Resource Id".PadRight(LOGICAL_RESOURCE_WIDTH) + " " +
                "Status".PadRight(RESOURCE_STATUS) + " ");

            log.Information(
                new string('-', TIMESTAMP_WIDTH) + " " +
                new string('-', LOGICAL_RESOURCE_WIDTH) + " " +
                new string('-', RESOURCE_STATUS) + " ");

            Stack stack;
            do
            {
                await Task.Delay(POLLING_PERIOD).ConfigureAwait(false);
                stack = await GetExistingStackAsync(cloudformation, stackName).ConfigureAwait(false);

                var events = await GetLatestEventsAsync(log, cloudformation, stackName, mintimeStampForEvents, mostRecentEventId).ConfigureAwait(false);
                if (events.Count > 0)
                {
                    mostRecentEventId = events[0].EventId;
                }

                for (int i = events.Count - 1; i >= 0; i--)
                {
                    var line =
                        events[i].Timestamp.ToString("g").PadRight(TIMESTAMP_WIDTH) + " " +
                        events[i].LogicalResourceId.PadRight(LOGICAL_RESOURCE_WIDTH) + " " +
                        events[i].ResourceStatus.ToString().PadRight(RESOURCE_STATUS);

                    // To save screen space only show error messages.
                    if (!events[i].ResourceStatus.ToString().EndsWith(IN_PROGRESS_SUFFIX) && !string.IsNullOrEmpty(events[i].ResourceStatusReason))
                        line += " " + events[i].ResourceStatusReason;

                    log.Information(line);
                }

            } while (stack.StackStatus.ToString().EndsWith(IN_PROGRESS_SUFFIX));

            return stack;
        }

        private static async Task<List<StackEvent>> GetLatestEventsAsync(ILogger log, IAmazonCloudFormation cloudformation, string stackName, DateTime mintimeStampForEvents, string mostRecentEventId)
        {
            var noNewEvents = false;
            var events = new List<StackEvent>();

            DescribeStackEventsResponse response = null;
            do
            {
                var request = new DescribeStackEventsRequest { StackName = stackName };
                if (response != null)
                {
                    request.NextToken = response.NextToken;
                }

                try
                {
                    response = await cloudformation.DescribeStackEventsAsync(request).ConfigureAwait(false);
                }
                catch (Exception e)
                {
                    log.Error(e, "Error getting events for stack");
                    throw;
                }

                foreach (var evnt in response.StackEvents)
                {
                    if (string.Equals(evnt.EventId, mostRecentEventId) || evnt.Timestamp < mintimeStampForEvents)
                    {
                        noNewEvents = true;
                        break;
                    }
                    events.Add(evnt);
                }

            } while (!noNewEvents && !string.IsNullOrEmpty(response.NextToken));

            return events;
        }

        private static void DisplayOutputs(ILogger log, Stack stack)
        {
            if (stack.Outputs.Count == 0)
                return;

            const int OUTPUT_NAME_WIDTH = 30;
            const int OUTPUT_VALUE_WIDTH = 50;

            log.Information("   ");
            log.Information("Output Name".PadRight(OUTPUT_NAME_WIDTH) + " " + "Value".PadRight(OUTPUT_VALUE_WIDTH));
            log.Information($"{new string('-', OUTPUT_NAME_WIDTH)} {new string('-', OUTPUT_VALUE_WIDTH)}");

            foreach (var output in stack.Outputs)
            {
                var line = output.OutputKey.PadRight(OUTPUT_NAME_WIDTH) + " " + output.OutputValue?.PadRight(OUTPUT_VALUE_WIDTH);
                log.Information(line);
            }
        }

        private static async Task<DeployStackResult> WaitForChangeSetBeingAvailableAsync(ILogger log, IAmazonCloudFormation cloudformation, string changeSetId)
        {
            try
            {
                var request = new DescribeChangeSetRequest
                {
                    ChangeSetName = changeSetId
                };

                log.Information("... Waiting for change set to be reviewed");

                DescribeChangeSetResponse response;
                do
                {
                    await Task.Delay(POLLING_PERIOD).ConfigureAwait(false);
                    response = await cloudformation.DescribeChangeSetAsync(request).ConfigureAwait(false);

                } while (response.Status == ChangeSetStatus.CREATE_IN_PROGRESS || response.Status == ChangeSetStatus.CREATE_PENDING);

                if (response.Status == ChangeSetStatus.FAILED)
                {
                    if (response.StatusReason == "The submitted information didn't contain changes. Submit different information to create a change set.")
                    {
                        log.Information("Cloudformation update not needed.");
                        return DeployStackResult.NoChanges;
                    }

                    log.Information($"Failed to create CloudFormation change set: {response.StatusReason}");
                    return DeployStackResult.Failed;
                }

                return DeployStackResult.Ok;
            }
            catch (Exception e)
            {
                log.Error(e, "Error getting status of change set");
                throw;
            }
        }

        private static async Task DeleteRollbackCompleteStackAsync(ILogger log, IAmazonCloudFormation cloudformation, Stack stack)
        {
            try
            {
                if (stack.StackStatus == StackStatus.ROLLBACK_COMPLETE)
                {
                    await cloudformation.DeleteStackAsync(new DeleteStackRequest { StackName = stack.StackName }).ConfigureAwait(false);
                }

                await WaitForNoLongerInProgress(log, cloudformation, stack.StackName).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error removing previous failed stack creation {stackName}", stack.StackName);
                throw;
            }
        }

        private static async Task<Stack> WaitForNoLongerInProgress(ILogger log, IAmazonCloudFormation cloudformation, string stackName)
        {
            try
            {
                long start = DateTime.Now.Ticks;
                Stack currentStack = null;
                do
                {
                    if (currentStack != null)
                    {
                        log.Information($"... Waiting for stack's state to change from {currentStack.StackStatus}: {TimeSpan.FromTicks(DateTime.Now.Ticks - start).TotalSeconds.ToString("0").PadLeft(3)} secs");
                    }
                    await Task.Delay(POLLING_PERIOD).ConfigureAwait(false);
                    currentStack = await GetExistingStackAsync(cloudformation, stackName).ConfigureAwait(false);

                } while (currentStack != null && currentStack.StackStatus.ToString().EndsWith(IN_PROGRESS_SUFFIX));

                return currentStack;
            }
            catch (Exception e)
            {
                log.Error(e, "Error waiting for stack state change");
                throw;
            }
        }

        public static async Task<Stack> GetExistingStackAsync(IAmazonCloudFormation cloudformation, string stackName)
        {
            try
            {
                var request = new DescribeStacksRequest { StackName = stackName };
                var response = await cloudformation.DescribeStacksAsync(request).ConfigureAwait(false);
                if (response.Stacks.Count != 1)
                    return null;

                return response.Stacks[0];
            }
            catch (AmazonCloudFormationException)
            {
                return null;
            }
        }

        public static async Task<StackSet> GetExistingStackSetAsync(IAmazonCloudFormation cloudformation, string stackSetName)
        {
            try
            {
                var request = new DescribeStackSetRequest { StackSetName = stackSetName };
                var response = await cloudformation.DescribeStackSetAsync(request).ConfigureAwait(false);
                return response.StackSet;
            }
            catch (AmazonCloudFormationException)
            {
                return null;
            }
        }

        public static string GetStackOutput(this Stack stack, string key)
        {
            var output = stack.Outputs.FirstOrDefault(x => x.OutputKey == key);
            if (output == null)
            {
                throw new Exception($"Stack {stack.StackName} missing output: {key}");
            }
            var result = output.OutputValue;
            return result;
        }
    }
}