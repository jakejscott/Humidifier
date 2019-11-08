namespace Humidifier.Events
{
    using System.Collections.Generic;
    using RuleTypes;

    public class Rule : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Events::Rule";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// EventBusName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-eventbusname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventBusName
        {
            get;
            set;
        }

        /// <summary>
        /// EventPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-eventpattern
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic EventPattern
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// ScheduleExpression
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-scheduleexpression
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScheduleExpression
        {
            get;
            set;
        }

        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State
        {
            get;
            set;
        }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-events-rule.html#cfn-events-rule-targets
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Target
        /// </summary>
        public List<Target> Targets
        {
            get;
            set;
        }
    }

    namespace RuleTypes
    {
        public class RunCommandParameters
        {
            /// <summary>
            /// RunCommandTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandparameters.html#cfn-events-rule-runcommandparameters-runcommandtargets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RunCommandTarget
            /// </summary>
            public List<RunCommandTarget> RunCommandTargets
            {
                get;
                set;
            }
        }

        public class NetworkConfiguration
        {
            /// <summary>
            /// AwsVpcConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-networkconfiguration.html#cfn-events-rule-networkconfiguration-awsvpcconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AwsVpcConfiguration
            /// </summary>
            public AwsVpcConfiguration AwsVpcConfiguration
            {
                get;
                set;
            }
        }

        public class RunCommandTarget
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html#cfn-events-rule-runcommandtarget-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-runcommandtarget.html#cfn-events-rule-runcommandtarget-values
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values
            {
                get;
                set;
            }
        }

        public class InputTransformer
        {
            /// <summary>
            /// InputPathsMap
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputpathsmap
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> InputPathsMap
            {
                get;
                set;
            }

            /// <summary>
            /// InputTemplate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-inputtransformer.html#cfn-events-rule-inputtransformer-inputtemplate
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputTemplate
            {
                get;
                set;
            }
        }

        public class BatchRetryStrategy
        {
            /// <summary>
            /// Attempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchretrystrategy.html#cfn-events-rule-batchretrystrategy-attempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Attempts
            {
                get;
                set;
            }
        }

        public class SqsParameters
        {
            /// <summary>
            /// MessageGroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-sqsparameters.html#cfn-events-rule-sqsparameters-messagegroupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageGroupId
            {
                get;
                set;
            }
        }

        public class Target
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-arn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn
            {
                get;
                set;
            }

            /// <summary>
            /// BatchParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-batchparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchParameters
            /// </summary>
            public BatchParameters BatchParameters
            {
                get;
                set;
            }

            /// <summary>
            /// EcsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-ecsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EcsParameters
            /// </summary>
            public EcsParameters EcsParameters
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// Input
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-input
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Input
            {
                get;
                set;
            }

            /// <summary>
            /// InputPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-inputpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InputPath
            {
                get;
                set;
            }

            /// <summary>
            /// InputTransformer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-inputtransformer
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputTransformer
            /// </summary>
            public InputTransformer InputTransformer
            {
                get;
                set;
            }

            /// <summary>
            /// KinesisParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-kinesisparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisParameters
            /// </summary>
            public KinesisParameters KinesisParameters
            {
                get;
                set;
            }

            /// <summary>
            /// RoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-rolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleArn
            {
                get;
                set;
            }

            /// <summary>
            /// RunCommandParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-runcommandparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RunCommandParameters
            /// </summary>
            public RunCommandParameters RunCommandParameters
            {
                get;
                set;
            }

            /// <summary>
            /// SqsParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-target.html#cfn-events-rule-target-sqsparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SqsParameters
            /// </summary>
            public SqsParameters SqsParameters
            {
                get;
                set;
            }
        }

        public class KinesisParameters
        {
            /// <summary>
            /// PartitionKeyPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-kinesisparameters.html#cfn-events-rule-kinesisparameters-partitionkeypath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PartitionKeyPath
            {
                get;
                set;
            }
        }

        public class BatchArrayProperties
        {
            /// <summary>
            /// Size
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batcharrayproperties.html#cfn-events-rule-batcharrayproperties-size
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Size
            {
                get;
                set;
            }
        }

        public class EcsParameters
        {
            /// <summary>
            /// Group
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-group
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Group
            {
                get;
                set;
            }

            /// <summary>
            /// LaunchType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-launchtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LaunchType
            {
                get;
                set;
            }

            /// <summary>
            /// NetworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-networkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkConfiguration
            /// </summary>
            public NetworkConfiguration NetworkConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// PlatformVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-platformversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PlatformVersion
            {
                get;
                set;
            }

            /// <summary>
            /// TaskCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TaskCount
            {
                get;
                set;
            }

            /// <summary>
            /// TaskDefinitionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-ecsparameters.html#cfn-events-rule-ecsparameters-taskdefinitionarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TaskDefinitionArn
            {
                get;
                set;
            }
        }

        public class AwsVpcConfiguration
        {
            /// <summary>
            /// AssignPublicIp
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-assignpublicip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AssignPublicIp
            {
                get;
                set;
            }

            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-awsvpcconfiguration.html#cfn-events-rule-awsvpcconfiguration-subnets
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets
            {
                get;
                set;
            }
        }

        public class BatchParameters
        {
            /// <summary>
            /// ArrayProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-arrayproperties
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchArrayProperties
            /// </summary>
            public BatchArrayProperties ArrayProperties
            {
                get;
                set;
            }

            /// <summary>
            /// JobDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobDefinition
            {
                get;
                set;
            }

            /// <summary>
            /// JobName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-jobname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobName
            {
                get;
                set;
            }

            /// <summary>
            /// RetryStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-events-rule-batchparameters.html#cfn-events-rule-batchparameters-retrystrategy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BatchRetryStrategy
            /// </summary>
            public BatchRetryStrategy RetryStrategy
            {
                get;
                set;
            }
        }
    }
}