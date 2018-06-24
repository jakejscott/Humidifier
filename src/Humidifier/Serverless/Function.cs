using System.Collections.Generic;
using Humidifier.Serverless.FunctionTypes;

namespace Humidifier.Serverless
{
    // TODO: Support Globals section? Might not be that necessary as you could just use setup the defaults in C# code.
    // https://github.com/awslabs/serverless-application-model/blob/master/docs/globals.rst

    public class Function : Resource
    {
        public static class Attributes
        {
            public static string Arn = "Arn";
        }

        public override string AWSTypeName => "AWS::Serverless::Function";

        /// <summary>
        /// Function within your code that is called to begin execution.
        /// Required.
        /// Type: String.
        /// </summary>
        public dynamic Handler { get; set; }

        /// <summary>
        /// The runtime environment.
        /// Required.
        /// Type: String.
        /// </summary>
        public dynamic Runtime { get; set; }

        /// <summary>
        /// S3 Uri or location to the function code. The S3 object this Uri references MUST be a Lambda deployment package. Required.
        /// Type: String | S3 Location Object https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#s3-location-object
        /// </summary>
        public dynamic CodeUri { get; set; }

        /// <summary>
        /// A name for the function. If you don't specify a name, a unique name will be generated for you.
        /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-functionname
        /// </summary>
        public dynamic FunctionName { get; set; }

        /// <summary>
        /// Description of the function.
        /// Type: String.
        /// </summary>
        public dynamic Description { get; set; }

        /// <summary>
        /// Size of the memory allocated per invocation of the function in MB.
        /// Defaults to 128.
        /// Type: Integer.
        /// </summary>
        public dynamic MemorySize { get; set; }

        /// <summary>
        /// Maximum time that the function can run before it is killed in seconds.
        /// Defaults to 3.
        /// Type: Integer.
        /// </summary>
        public dynamic Timeout { get; set; }

        /// <summary>
        /// ARN of an IAM role to use as this function's execution role. If omitted, a default role is created for this function.
        /// Type: String.
        /// </summary>
        public dynamic Role { get; set; }

        /// <summary>
        /// Names of AWS managed IAM policies or IAM policy documents or SAM Policy Templates that this function needs, which should be appended to the default role for this function. If the Role property is set, this property has no meaning.
        /// Type: String | List of string | IAM policy document object | List of IAM policy document object | List of SAM Policy Templates
        /// </summary>
        public dynamic Policies { get; set; }

        /// <summary>
        /// Environment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-environment
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Environment
        /// </summary>
        public Environment Environment { get; set; }

        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-vpcconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VpcConfig
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// A map (string to Event source object) that defines the events that trigger this function. Keys are limited to alphanumeric characters.
        /// </summary>
        public Dictionary<string, EventSource> Events { get; set; }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// String that specifies the function's X-Ray tracing mode. Accepted values are Active and PassThrough
        /// Type: String.
        /// </summary>
        public dynamic Tracing { get; set; }

        /// <summary>
        /// The Amazon Resource Name (ARN) of an AWS Key Management Service (AWS KMS) key that Lambda uses to encrypt and decrypt your function's environment variables.
        /// Type: String.
        /// </summary>
        public dynamic KmsKeyArn { get; set; }

        /// <summary>
        /// Configures SNS topic or SQS queue where Lambda sends events that it can't process.
        /// https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md#deadletterqueue-object
        /// Specifies an SQS queue or SNS topic that AWS Lambda (Lambda) sends events to when it can't process them.
        ///
        /// For more information about DLQ functionality, refer to the officiall documentation at http://docs.aws.amazon.com/lambda/latest/dg/dlq.html.
        /// SAM will automatically add appropriate permission to your Lambda function execution role to give Lambda service access to the resource. sqs:SendMessage will be added for SQS queues and sns:Publish for SNS topics.
        /// </summary>
        public DeadLetterQueue DeadLetterQueue { get; set; }

        /// <summary>
        /// Settings to enable Safe Lambda Deployments. Read the usage guide for detailed information.
        /// https://github.com/awslabs/serverless-application-model/blob/master/docs/safe_lambda_deployments.rst
        /// </summary>
        public DeploymentPreference DeploymentPreference { get; set; }

        /// <summary>
        /// Name of the Alias. Read AutoPublishAlias Guide for how it works
        /// Type: String
        /// https://github.com/awslabs/serverless-application-model/blob/master/docs/safe_lambda_deployments.rst#instant-traffic-shifting-using-lambda-aliases
        /// </summary>
        public dynamic AutoPublishAlias { get; set; }

        /// <summary>
        /// The maximum of concurrent executions you want to reserve for the function. 
        /// https://docs.aws.amazon.com/lambda/latest/dg/concurrent-executions.html
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-reservedconcurrentexecutions
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ReservedConcurrentExecutions { get; set; }
    }

    namespace FunctionTypes
    {
        public class DeploymentPreference
        {
            /// <summary>
            /// Required: false
            /// Type: bool
            /// </summary>
            public dynamic Enabled { get; set; }

            /// <summary>
            /// Type: String
            /// https://github.com/awslabs/serverless-application-model/blob/master/docs/safe_lambda_deployments.rst#traffic-shifting-configurations
            /// Canary10Percent5Minutes
            /// Canary10Percent10Minutes
            /// Canary10Percent15Minutes
            /// AllAtOnce
            /// Linear10PercentEvery10Minutes
            /// Linear10PercentEvery1Minute
            /// Linear10PercentEvery2Minutes
            /// Linear10PercentEvery3Minutes 
            /// </summary>
            public dynamic Type { get; set; }
            public List<dynamic> Alarms { get; set; }
            public Hooks Hooks { get; set; }
        }

        public class Hooks
        {
            public dynamic PreTraffic { get; set; }
            public dynamic PostTraffic { get; set; }
        }

        public class VpcConfig
        {
            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds { get; set; }

            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-vpcconfig.html#cfn-lambda-function-vpcconfig-subnetids
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SubnetIds { get; set; }
        }

        public class Environment
        {
            /// <summary>
            /// Variables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-function-environment.html#cfn-lambda-function-environment-variables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Variables { get; set; }
        }

        public class DeadLetterQueue
        {
            /// <summary>
            /// e.g SQS or SNS
            /// </summary>
            public string Type { get; set; }

            /// <summary>
            /// ARN of the SQS queue or SNS topic to use as DLQ. 
            /// </summary>
            public dynamic TargetArn { get; set; }
        }

        public class S3LocationObject
        {
            public dynamic Bucket { get; set; }
            public dynamic Key { get; set; }
            public dynamic Version { get; set; }
        }

        public abstract class EventSource
        {
            /// <summary>
            /// S3, SNS, Kinesis, DynamoDB, Api, Schedule, CloudWatchEvent, CloudWatchLogs, IoTRule, AlexaSkill
            /// </summary>
            public abstract string Type { get; }
        }

        public class SnsEventSource : EventSource
        {
            public override string Type { get; } = "Sns";
            public SnsEventSourceProperties Properties { get; set; }
        }

        public class SnsEventSourceProperties
        {
            /// <summary>
            /// Topic ARN.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic Topic { get; set; }
        }

        public class KinesisEventSource : EventSource
        {
            public override string Type { get; } = "Kinesis";
            public KinesisEventSourceProperties Properties { get; set; }
        }

        public class KinesisEventSourceProperties
        {
            /// <summary>
            /// ARN of the DynamoDB stream.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic Stream { get; set; }

            /// <summary>
            /// One of TRIM_HORIZON or LATEST.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic StartingPosition { get; set; }

            /// <summary>
            /// Maximum number of stream records to process per function invocation.
            /// Type: integer
            /// /// </summary>
            public dynamic BatchSize { get; set; }
        }

        public class DynamoDbEventSource : EventSource
        {
            public override string Type { get; } = "DynamoDB";
            public DynamoDbEventSourceProperties Properties { get; set; }
        }

        public class DynamoDbEventSourceProperties
        {
            /// <summary>
            /// ARN of the DynamoDB stream.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic Stream { get; set; }

            /// <summary>
            /// One of TRIM_HORIZON or LATEST.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic StartingPosition { get; set; }

            /// <summary>
            /// Maximum number of stream records to process per function invocation.
            /// Type: integer
            /// </summary>
            public dynamic BatchSize { get; set; }
        }

        public class ScheduleEventSource : EventSource
        {
            public override string Type { get; } = "Schedule";
            public ScheduleEventSourceProperties Properties { get; set; }
        }

        public class ScheduleEventSourceProperties
        {
            /// <summary>
            /// Schedule expression, which MUST follow the schedule expression syntax rules.
            /// Type: String
            /// https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/ScheduledEvents.html
            /// </summary>
            public dynamic Schedule { get; set; }

            /// <summary>
            /// JSON-formatted string to pass to the function as the event body.
            /// </summary>
            public dynamic Input { get; set; }
        }

        public class ApiEventSource : EventSource
        {
            public override string Type { get; } = "Api";
            public ApiEventSourceProperties Properties { get; set; }
        }

        public class ApiEventSourceProperties
        {
            /// <summary>
            /// Uri path for which this function is invoked. MUST start with /.
            /// Type: String
            /// Required.
            /// </summary>
            public string Path { get; set; }

            /// <summary>
            /// HTTP method for which this function is invoked.
            /// Type: String
            /// Required.
            /// </summary>
            public string Method { get; set; }

            /// <summary>
            /// Identifier of a RestApi resource which MUST contain an operation with the given path and method. Typically, this is set to reference an AWS::Serverless::Api resource defined in this template. If not defined, a default AWS::Serverless::Api resource is created using a generated Swagger document contains a union of all paths and methods defined by Api events defined in this template that do not specify a RestApiId.
            /// Type: String 
            /// </summary>
            public string RestApiId { get; set; }
        }

        public class CloudWatchEventEventSource : EventSource
        {
            public override string Type { get; } = "CloudWatchEvent";
            public CloudWatchEventEventSourceProperties Properties { get; set; }
        }

        public class CloudWatchEventEventSourceProperties
        {
            /// <summary>
            /// Pattern describing which CloudWatch events trigger the function. Only matching events trigger the function.
            /// Type: Event Pattern Object
            /// Required.
            /// https://docs.aws.amazon.com/AmazonCloudWatch/latest/events/CloudWatchEventsandEventPatterns.html
            /// </summary>
            public dynamic Pattern { get; set; }

            /// <summary>
            /// JSON-formatted string to pass to the function as the event body. This value overrides the matched event.
            /// Type: JSON
            /// </summary>
            public dynamic Input { get; set; }

            /// <summary>
            /// JSONPath describing the part of the event to pass to the function.
            /// Type: JSON
            /// </summary>
            public dynamic InputPath { get; set; }
        }

        public class CloudWatchLogsEventSource : EventSource
        {
            public override string Type { get; } = "CloudWatchLogs";
            public CloudWatchLogsEventSourceProperties Properties { get; set; }
        }

        public class CloudWatchLogsEventSourceProperties
        {
            /// <summary>
            /// Name of the CloudWatch Log Group from which to process logs.
            /// Type: String
            /// Required
            /// </summary>
            public dynamic LogGroupName { get; set; }

            /// <summary>
            /// A CloudWatch Logs FilterPattern to specify which logs in the Log Group to process.
            /// Type: String
            /// Required
            /// https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html
            /// </summary>
            public dynamic FilterPattern { get; set; }
        }

        public class IoTRuleEventSource : EventSource
        {
            public override string Type { get; } = "IoTRule";
            public IoTRuleEventSourceProperties Properties { get; set; }
        }

        public class IoTRuleEventSourceProperties
        {
            /// <summary>
            /// The SQL statement that queries the topic. For more information, see Rules for AWS IoT in the AWS IoT Developer Guide.
            /// Type: String
            /// Required.
            /// http://docs.aws.amazon.com/iot/latest/developerguide/iot-rules.html#aws-iot-sql-reference
            /// </summary>
            public dynamic Sql { get; set; }

            /// <summary>
            /// The version of the SQL rules engine to use when evaluating the rule.
            /// Type: String
            /// </summary>
            public dynamic AwsIotSqlVersion { get; set; }
        }

        public class AlexaSkillEventSource : EventSource
        {
            public override string Type { get; } = "AlexaSkill";
            public AlexaSkillEventSourceProperties Properties { get; set; }
        }

        public class AlexaSkillEventSourceProperties
        {
        }

        public class S3EventSource : EventSource
        {
            public override string Type { get; } = "S3";
            public S3EventSourceProperties Properties { get; set; }
        }

        public class S3EventSourceProperties
        {
            /// <summary>
            /// S3 bucket name.
            /// e.g. my-photo-bucket
            /// Required.
            /// String
            /// </summary>
            public dynamic Bucket { get; set; }

            /// <summary>
            /// See Amazon S3 supported event types for valid values.
            /// https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html#supported-notification-event-types
            /// e.g s3:ObjectCreated
            /// Required
            /// string | List of string
            /// </summary>
            public dynamic Events { get; set; }

            /// <summary>
            /// Rules to filter events on.
            /// https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html
            /// JSON
            /// </summary>
            public dynamic Filter { get; set; }
        }
    }

    
}