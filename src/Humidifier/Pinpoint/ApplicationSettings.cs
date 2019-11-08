namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;
    using ApplicationSettingsTypes;

    public class ApplicationSettings : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Pinpoint::ApplicationSettings";
            }
        }

        /// <summary>
        /// QuietTime
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-quiettime
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuietTime
        /// </summary>
        public QuietTime QuietTime
        {
            get;
            set;
        }

        /// <summary>
        /// Limits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-limits
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Limits
        /// </summary>
        public Limits Limits
        {
            get;
            set;
        }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationId
        {
            get;
            set;
        }

        /// <summary>
        /// CampaignHook
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-campaignhook
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CampaignHook
        /// </summary>
        public CampaignHook CampaignHook
        {
            get;
            set;
        }

        /// <summary>
        /// CloudWatchMetricsEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-applicationsettings.html#cfn-pinpoint-applicationsettings-cloudwatchmetricsenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CloudWatchMetricsEnabled
        {
            get;
            set;
        }
    }

    namespace ApplicationSettingsTypes
    {
        public class Limits
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-daily
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Daily
            {
                get;
                set;
            }

            /// <summary>
            /// MaximumDuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-maximumduration
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaximumDuration
            {
                get;
                set;
            }

            /// <summary>
            /// Total
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-total
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Total
            {
                get;
                set;
            }

            /// <summary>
            /// MessagesPerSecond
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-limits.html#cfn-pinpoint-applicationsettings-limits-messagespersecond
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MessagesPerSecond
            {
                get;
                set;
            }
        }

        public class CampaignHook
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-mode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mode
            {
                get;
                set;
            }

            /// <summary>
            /// WebUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-weburl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebUrl
            {
                get;
                set;
            }

            /// <summary>
            /// LambdaFunctionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-campaignhook.html#cfn-pinpoint-applicationsettings-campaignhook-lambdafunctionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaFunctionName
            {
                get;
                set;
            }
        }

        public class QuietTime
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-quiettime.html#cfn-pinpoint-applicationsettings-quiettime-start
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Start
            {
                get;
                set;
            }

            /// <summary>
            /// End
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-applicationsettings-quiettime.html#cfn-pinpoint-applicationsettings-quiettime-end
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic End
            {
                get;
                set;
            }
        }
    }
}