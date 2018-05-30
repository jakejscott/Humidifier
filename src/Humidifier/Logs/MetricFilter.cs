namespace Humidifier.Logs
{
    using System.Collections.Generic;
    using MetricFilterTypes;

    public class MetricFilter : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Logs::MetricFilter";
            }
        }

        /// <summary>
        /// FilterPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-filterpattern
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FilterPattern
        {
            get;
            set;
        }

        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-loggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// MetricTransformations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-metricfilter.html#cfn-cwl-metricfilter-metrictransformations
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricTransformation
        /// </summary>
        public List<MetricTransformation> MetricTransformations
        {
            get;
            set;
        }
    }

    namespace MetricFilterTypes
    {
        public class MetricTransformation
        {
            /// <summary>
            /// DefaultValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-cwl-metricfilter-metrictransformation-defaultvalue
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DefaultValue
            {
                get;
                set;
            }

            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-cwl-metricfilter-metrictransformation-metricname
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
            /// MetricNamespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-cwl-metricfilter-metrictransformation-metricnamespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricNamespace
            {
                get;
                set;
            }

            /// <summary>
            /// MetricValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-logs-metricfilter-metrictransformation.html#cfn-cwl-metricfilter-metrictransformation-metricvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricValue
            {
                get;
                set;
            }
        }
    }
}