namespace Humidifier.EMR
{
    using System.Collections.Generic;
    using InstanceGroupConfigPropertyTypes;

    public class InstanceGroupConfig : Humidifier.Resource
    {
        /// <summary>
        /// AutoScalingPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-elasticmapreduce-instancegroupconfig-autoscalingpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoScalingPolicy
        /// </summary>
        public AutoScalingPolicy AutoScalingPolicy
        {
            get;
            set;
        }

        /// <summary>
        /// BidPrice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-bidprice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BidPrice
        {
            get;
            set;
        }

        /// <summary>
        /// Configurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-configurations
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Configuration
        /// </summary>
        public List<Configuration> Configurations
        {
            get;
            set;
        }

        /// <summary>
        /// EbsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-ebsconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: EbsConfiguration
        /// </summary>
        public EbsConfiguration EbsConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceCount
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfiginstancecount-
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int InstanceCount
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancerole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceRole
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-instancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceType
        {
            get;
            set;
        }

        /// <summary>
        /// JobFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-jobflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobFlowId
        {
            get;
            set;
        }

        /// <summary>
        /// Market
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-market
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Market
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-instancegroupconfig.html#cfn-emr-instancegroupconfig-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace InstanceGroupConfigPropertyTypes
    {
        public class ScalingAction
        {
            /// <summary>
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingaction.html#cfn-elasticmapreduce-instancegroupconfig-scalingaction-market
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Market
            {
                get;
                set;
            }

            /// <summary>
            /// SimpleScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingaction.html#cfn-elasticmapreduce-instancegroupconfig-scalingaction-simplescalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SimpleScalingPolicyConfiguration
            /// </summary>
            public SimpleScalingPolicyConfiguration SimpleScalingPolicyConfiguration
            {
                get;
                set;
            }
        }

        public class ScalingTrigger
        {
            /// <summary>
            /// CloudWatchAlarmDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingtrigger.html#cfn-elasticmapreduce-instancegroupconfig-scalingtrigger-cloudwatchalarmdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchAlarmDefinition
            /// </summary>
            public CloudWatchAlarmDefinition CloudWatchAlarmDefinition
            {
                get;
                set;
            }
        }

        public class EbsBlockDeviceConfig
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VolumeSpecification
            /// </summary>
            public VolumeSpecification VolumeSpecification
            {
                get;
                set;
            }

            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? VolumesPerInstance
            {
                get;
                set;
            }
        }

        public class Configuration
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification
            {
                get;
                set;
            }

            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-configurationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ConfigurationProperties
            {
                get;
                set;
            }

            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Configuration> Configurations
            {
                get;
                set;
            }
        }

        public class MetricDimension
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-metricdimension.html#cfn-elasticmapreduce-instancegroupconfig-metricdimension-key
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
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-metricdimension.html#cfn-elasticmapreduce-instancegroupconfig-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }

        public class ScalingConstraints
        {
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingconstraints.html#cfn-elasticmapreduce-instancegroupconfig-scalingconstraints-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int MaxCapacity
            {
                get;
                set;
            }

            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingconstraints.html#cfn-elasticmapreduce-instancegroupconfig-scalingconstraints-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int MinCapacity
            {
                get;
                set;
            }
        }

        public class CloudWatchAlarmDefinition
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator
            {
                get;
                set;
            }

            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public List<MetricDimension> Dimensions
            {
                get;
                set;
            }

            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? EvaluationPeriods
            {
                get;
                set;
            }

            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName
            {
                get;
                set;
            }

            /// <summary>
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace
            {
                get;
                set;
            }

            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int Period
            {
                get;
                set;
            }

            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Statistic
            {
                get;
                set;
            }

            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public double Threshold
            {
                get;
                set;
            }

            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-instancegroupconfig-cloudwatchalarmdefinition-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit
            {
                get;
                set;
            }
        }

        public class SimpleScalingPolicyConfiguration
        {
            /// <summary>
            /// AdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-adjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdjustmentType
            {
                get;
                set;
            }

            /// <summary>
            /// CoolDown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-cooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? CoolDown
            {
                get;
                set;
            }

            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-instancegroupconfig-simplescalingpolicyconfiguration-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ScalingAdjustment
            {
                get;
                set;
            }
        }

        public class VolumeSpecification
        {
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? Iops
            {
                get;
                set;
            }

            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int SizeInGB
            {
                get;
                set;
            }

            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType
            {
                get;
                set;
            }
        }

        public class ScalingRule
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html#cfn-elasticmapreduce-instancegroupconfig-scalingrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingAction
            /// </summary>
            public ScalingAction Action
            {
                get;
                set;
            }

            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html#cfn-elasticmapreduce-instancegroupconfig-scalingrule-description
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
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html#cfn-elasticmapreduce-instancegroupconfig-scalingrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-scalingrule.html#cfn-elasticmapreduce-instancegroupconfig-scalingrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingTrigger
            /// </summary>
            public ScalingTrigger Trigger
            {
                get;
                set;
            }
        }

        public class AutoScalingPolicy
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-autoscalingpolicy.html#cfn-elasticmapreduce-instancegroupconfig-autoscalingpolicy-constraints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingConstraints
            /// </summary>
            public ScalingConstraints Constraints
            {
                get;
                set;
            }

            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancegroupconfig-autoscalingpolicy.html#cfn-elasticmapreduce-instancegroupconfig-autoscalingpolicy-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScalingRule
            /// </summary>
            public List<ScalingRule> Rules
            {
                get;
                set;
            }
        }

        public class EbsConfiguration
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs
            {
                get;
                set;
            }

            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? EbsOptimized
            {
                get;
                set;
            }
        }
    }
}