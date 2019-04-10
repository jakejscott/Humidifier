namespace Humidifier.KinesisAnalyticsV2
{
    using System.Collections.Generic;
    using ApplicationCloudWatchLoggingOptionTypes;

    public class ApplicationCloudWatchLoggingOption : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::KinesisAnalyticsV2::ApplicationCloudWatchLoggingOption";
            }
        }

        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationcloudwatchloggingoption.html#cfn-kinesisanalyticsv2-applicationcloudwatchloggingoption-applicationname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName
        {
            get;
            set;
        }

        /// <summary>
        /// CloudWatchLoggingOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalyticsv2-applicationcloudwatchloggingoption.html#cfn-kinesisanalyticsv2-applicationcloudwatchloggingoption-cloudwatchloggingoption
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CloudWatchLoggingOption
        /// </summary>
        public CloudWatchLoggingOption CloudWatchLoggingOption
        {
            get;
            set;
        }
    }

    namespace ApplicationCloudWatchLoggingOptionTypes
    {
        public class CloudWatchLoggingOption
        {
            /// <summary>
            /// LogStreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalyticsv2-applicationcloudwatchloggingoption-cloudwatchloggingoption.html#cfn-kinesisanalyticsv2-applicationcloudwatchloggingoption-cloudwatchloggingoption-logstreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamARN
            {
                get;
                set;
            }
        }
    }
}