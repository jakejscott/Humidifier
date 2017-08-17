namespace Humidifier.AutoScaling
{
    using System.Collections.Generic;
    using ScalingPolicyPropertyTypes;

    public class ScalingPolicy : Humidifier.Resource
    {
        /// <summary>
        /// AdjustmentType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-adjustmenttype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AdjustmentType
        {
            get;
            set;
        }

        /// <summary>
        /// AutoScalingGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-autoscalinggroupname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoScalingGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// Cooldown
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-cooldown
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Cooldown
        {
            get;
            set;
        }

        /// <summary>
        /// EstimatedInstanceWarmup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-estimatedinstancewarmup
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? EstimatedInstanceWarmup
        {
            get;
            set;
        }

        /// <summary>
        /// MetricAggregationType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-metricaggregationtype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetricAggregationType
        {
            get;
            set;
        }

        /// <summary>
        /// MinAdjustmentMagnitude
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-minadjustmentmagnitude
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? MinAdjustmentMagnitude
        {
            get;
            set;
        }

        /// <summary>
        /// PolicyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-policytype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyType
        {
            get;
            set;
        }

        /// <summary>
        /// ScalingAdjustment
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-scalingadjustment
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? ScalingAdjustment
        {
            get;
            set;
        }

        /// <summary>
        /// StepAdjustments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-policy.html#cfn-as-scalingpolicy-stepadjustments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: StepAdjustment
        /// </summary>
        public List<StepAdjustment> StepAdjustments
        {
            get;
            set;
        }
    }

    namespace ScalingPolicyPropertyTypes
    {
        public class StepAdjustment
        {
            /// <summary>
            /// MetricIntervalLowerBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustments.html#cfn-autoscaling-scalingpolicy-stepadjustment-metricintervallowerbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public double ? MetricIntervalLowerBound
            {
                get;
                set;
            }

            /// <summary>
            /// MetricIntervalUpperBound
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustments.html#cfn-autoscaling-scalingpolicy-stepadjustment-metricintervalupperbound
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public double ? MetricIntervalUpperBound
            {
                get;
                set;
            }

            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-autoscaling-scalingpolicy-stepadjustments.html#cfn-autoscaling-scalingpolicy-stepadjustment-scalingadjustment
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
    }
}