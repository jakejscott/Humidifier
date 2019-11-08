namespace Humidifier.CloudWatch
{
    using System.Collections.Generic;
    using AnomalyDetectorTypes;

    public class AnomalyDetector : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CloudWatch::AnomalyDetector";
            }
        }

        /// <summary>
        /// MetricName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-metricname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MetricName
        {
            get;
            set;
        }

        /// <summary>
        /// Stat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-stat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Stat
        {
            get;
            set;
        }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Configuration
        /// </summary>
        public Configuration Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Dimensions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-dimensions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Dimension
        /// </summary>
        public List<Dimension> Dimensions
        {
            get;
            set;
        }

        /// <summary>
        /// Namespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudwatch-anomalydetector.html#cfn-cloudwatch-anomalydetector-namespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Namespace
        {
            get;
            set;
        }
    }

    namespace AnomalyDetectorTypes
    {
        public class Range
        {
            /// <summary>
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-range.html#cfn-cloudwatch-anomalydetector-range-endtime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EndTime
            {
                get;
                set;
            }

            /// <summary>
            /// StartTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-range.html#cfn-cloudwatch-anomalydetector-range-starttime
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime
            {
                get;
                set;
            }
        }

        public class Dimension
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-dimension.html#cfn-cloudwatch-anomalydetector-dimension-value
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-dimension.html#cfn-cloudwatch-anomalydetector-dimension-name
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class Configuration
        {
            /// <summary>
            /// MetricTimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-configuration.html#cfn-cloudwatch-anomalydetector-configuration-metrictimezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricTimeZone
            {
                get;
                set;
            }

            /// <summary>
            /// ExcludedTimeRanges
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudwatch-anomalydetector-configuration.html#cfn-cloudwatch-anomalydetector-configuration-excludedtimeranges
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Range
            /// </summary>
            public List<Range> ExcludedTimeRanges
            {
                get;
                set;
            }
        }
    }
}