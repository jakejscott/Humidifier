using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Amazon.CloudFormation.Model;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;
using Humidifier;
using Humidifier.IAM;
using ProjectBaseName.DeployTool.Util;
using Serilog;
using Output = Humidifier.Output;
using Parameter = Humidifier.Parameter;
using Stack = Humidifier.Stack;

namespace ProjectBaseName.DeployTool.Stacks
{
    public static class BaseStack
    {
        public static string Name(Config config) => config.Stack + "-base-" + config.Env;

        public static async Task<bool> Deploy(ILogger log, Context context)
        {
            var parameters = new Dictionary<string, string>
            {
                ["Environment"] = context.Config.Env
            };

            Stack stack = Build(context.Config);

            var template = context.JsonStackSerializer.Serialize(stack);

            var result = await Cloudformation.DeployStackAsync(log, context.Cloudformation, DateTime.Now.Ticks, Name(context.Config), context.Config.Tags, parameters, template);

            return result != DeployStackResult.Failed;
        }

        private static Stack Build(Config config)
        {
            var stack = new Stack
            {
                Description = "Base stack"
            };

            stack.Parameters.Add("Environment", new Parameter
            {
                Type = "String",
                MinLength = 3,
                AllowedValues = new List<string> { "test", "uat", "prod" }
            });
            
            stack.Resources.Add("CloudFormationServiceRole", new Role
            {
                Path = "/",
                AssumeRolePolicyDocument = new PolicyDocument
                {
                    Version = "2012-10-17",
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Effect = "Allow",
                            Principal = new { Service = "cloudformation.amazonaws.com" },
                            Action = "sts:AssumeRole"
                        }
                    }
                },
                Policies = new List<Policy>
                {
                    new Policy
                    {
                        PolicyName = "CloudformationExecutionPolicy",
                        PolicyDocument = new PolicyDocument
                        {
                            Version = "2012-10-17",
                            Statement = new List<Statement>
                            {
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "cloudwatch:*"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "logs:*"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "apigateway:*"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "route53:*"
                                },
                                new Statement
                                {
                                    Resource = "arn:aws:sns:*:*:*",
                                    Effect = "Allow",
                                    Action = "sns:ListTopics"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "lambda:*"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "cognito-idp:*"
                                },
                                new Statement
                                {
                                    Resource = "*",
                                    Effect = "Allow",
                                    Action = "cognito-identity:*"
                                },
                                new Statement
                                {
                                    Resource = $"arn:aws:sns:*:*:{config.Stack}-*",
                                    Effect = "Allow",
                                    Action = "sns:*"
                                },
                                new Statement
                                {
                                    Resource = $"arn:aws:s3:::{config.Stack}-*",
                                    Effect = "Allow",
                                    Action = "s3:*"
                                },
                                new Statement
                                {
                                    Resource = $"arn:aws:kinesis:*:*:stream/{config.Stack}-*",
                                    Effect = "Allow",
                                    Action = "kinesis:*"
                                },
                                new Statement
                                {
                                    Resource = $"arn:aws:firehose:*:*:deliverystream/{config.Stack}-*",
                                    Effect = "Allow",
                                    Action = "firehose:*"
                                },
                                new Statement
                                {
                                    Effect = "Allow",
                                    Action = "iam:*",
                                    Resource = new[]
                                    {
                                        $"arn:aws:iam::*:role/{config.Stack}-*",
                                        $"arn:aws:iam::*:policy/{config.Stack}-*"
                                    }
                                }
                            }
                        }
                    }
                }
            });

            stack.Add("DeploymentsBucket", new Humidifier.S3.Bucket
            {
                BucketName = Fn.Sub("${AWS::StackName}-deployments"),
            });

            stack.Outputs.Add("DeploymentsBucket", new Output
            {
                Value = Fn.Ref("DeploymentsBucket"),
                Export = new { Name = Fn.Sub("${AWS::StackName}-" + "DeploymentsBucket") }
            });

            stack.Outputs.Add("CloudFormationServiceRole", new Output
            {
                Value = Fn.GetAtt("CloudFormationServiceRole", "Arn"),
                Export = new { Name = Fn.Sub("${AWS::StackName}-" + "CloudFormationServiceRole") }
            });

            return stack;
        }

        public static async Task<bool> Destroy(ILogger log, Context context)
        {
            var baseStack = await Cloudformation.GetExistingStackAsync(context.Cloudformation, BaseStack.Name(context.Config)).ConfigureAwait(false);
            if (baseStack == null)
            {
                log.Error("Deploy the {stackName} stack first.", BaseStack.Name(context.Config));
                return false;
            }

            var role = baseStack.GetStackOutput("CloudFormationServiceRole");
            var bucket = baseStack.GetStackOutput("DeploymentsBucket");

            try
            {
                await AmazonS3Util.DeleteS3BucketWithObjectsAsync(context.S3, bucket);
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error deleting S3 bucket {bucket}. Message: {message}", bucket, ex.Message);
                return false;
            }

            var request = new DeleteStackRequest
            {
                StackName = Name(context.Config),
                RoleARN = role
            };
            try
            {
                await context.Cloudformation.DeleteStackAsync(request).ConfigureAwait(false);
                log.Information("CloudFormation stack {stackName} deleted", request.StackName);
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex, "Error deleting Cloudformation stack {stackName}", request.StackName);
                return false;
            }
        }
    }
}