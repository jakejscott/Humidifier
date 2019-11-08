namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;
    using CampaignTypes;

    public class Campaign : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string CampaignId =  "CampaignId" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Pinpoint::Campaign";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-description
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
        /// SegmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-segmentid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SegmentId
        {
            get;
            set;
        }

        /// <summary>
        /// IsPaused
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-ispaused
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic IsPaused
        {
            get;
            set;
        }

        /// <summary>
        /// AdditionalTreatments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-additionaltreatments
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: WriteTreatmentResource
        /// </summary>
        public List<WriteTreatmentResource> AdditionalTreatments
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-name
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
        /// SegmentVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-segmentversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SegmentVersion
        {
            get;
            set;
        }

        /// <summary>
        /// TreatmentDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-treatmentdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TreatmentDescription
        {
            get;
            set;
        }

        /// <summary>
        /// MessageConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-messageconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MessageConfiguration
        /// </summary>
        public MessageConfiguration MessageConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Limits
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-limits
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
        /// HoldoutPercent
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-holdoutpercent
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic HoldoutPercent
        {
            get;
            set;
        }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-schedule
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Schedule Schedule
        {
            get;
            set;
        }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-applicationid
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-campaignhook
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
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags
        {
            get;
            set;
        }

        /// <summary>
        /// TreatmentName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-campaign.html#cfn-pinpoint-campaign-treatmentname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TreatmentName
        {
            get;
            set;
        }
    }

    namespace CampaignTypes
    {
        public class MetricDimension
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-metricdimension.html#cfn-pinpoint-campaign-metricdimension-comparisonoperator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-metricdimension.html#cfn-pinpoint-campaign-metricdimension-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }

        public class SetDimension
        {
            /// <summary>
            /// DimensionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-setdimension.html#cfn-pinpoint-campaign-setdimension-dimensiontype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionType
            {
                get;
                set;
            }

            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-setdimension.html#cfn-pinpoint-campaign-setdimension-values
            /// Required: False
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

        public class EventDimensions
        {
            /// <summary>
            /// Metrics
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-metrics
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Metrics
            {
                get;
                set;
            }

            /// <summary>
            /// EventType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-eventtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SetDimension
            /// </summary>
            public SetDimension EventType
            {
                get;
                set;
            }

            /// <summary>
            /// Attributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-eventdimensions.html#cfn-pinpoint-campaign-eventdimensions-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Attributes_
            {
                get;
                set;
            }
        }

        public class Schedule
        {
            /// <summary>
            /// TimeZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-timezone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeZone
            {
                get;
                set;
            }

            /// <summary>
            /// QuietTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-quiettime
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
            /// EndTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-endtime
            /// Required: False
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-starttime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StartTime
            {
                get;
                set;
            }

            /// <summary>
            /// Frequency
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-frequency
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Frequency
            {
                get;
                set;
            }

            /// <summary>
            /// EventFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-eventfilter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignEventFilter
            /// </summary>
            public CampaignEventFilter EventFilter
            {
                get;
                set;
            }

            /// <summary>
            /// IsLocalTime
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule.html#cfn-pinpoint-campaign-schedule-islocaltime
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IsLocalTime
            {
                get;
                set;
            }
        }

        public class Limits
        {
            /// <summary>
            /// Daily
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-daily
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-maximumduration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-total
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-limits.html#cfn-pinpoint-campaign-limits-messagespersecond
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

        public class AttributeDimension
        {
            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-attributedimension.html#cfn-pinpoint-campaign-attributedimension-attributetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeType
            {
                get;
                set;
            }

            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-attributedimension.html#cfn-pinpoint-campaign-attributedimension-values
            /// Required: False
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

        public class MessageConfiguration
        {
            /// <summary>
            /// APNSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-apnsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Message APNSMessage
            {
                get;
                set;
            }

            /// <summary>
            /// BaiduMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-baidumessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Message BaiduMessage
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-defaultmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Message DefaultMessage
            {
                get;
                set;
            }

            /// <summary>
            /// EmailMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-emailmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignEmailMessage
            /// </summary>
            public CampaignEmailMessage EmailMessage
            {
                get;
                set;
            }

            /// <summary>
            /// GCMMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-gcmmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Message GCMMessage
            {
                get;
                set;
            }

            /// <summary>
            /// SMSMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-smsmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CampaignSmsMessage
            /// </summary>
            public CampaignSmsMessage SMSMessage
            {
                get;
                set;
            }

            /// <summary>
            /// ADMMessage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-messageconfiguration.html#cfn-pinpoint-campaign-messageconfiguration-admmessage
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Message
            /// </summary>
            public Message ADMMessage
            {
                get;
                set;
            }
        }

        public class QuietTime
        {
            /// <summary>
            /// Start
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule-quiettime.html#cfn-pinpoint-campaign-schedule-quiettime-start
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-schedule-quiettime.html#cfn-pinpoint-campaign-schedule-quiettime-end
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

        public class CampaignHook
        {
            /// <summary>
            /// Mode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-mode
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-weburl
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignhook.html#cfn-pinpoint-campaign-campaignhook-lambdafunctionname
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

        public class Message
        {
            /// <summary>
            /// JsonBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-jsonbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonBody
            {
                get;
                set;
            }

            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-action
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Action
            {
                get;
                set;
            }

            /// <summary>
            /// MediaUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-mediaurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MediaUrl
            {
                get;
                set;
            }

            /// <summary>
            /// TimeToLive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-timetolive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeToLive
            {
                get;
                set;
            }

            /// <summary>
            /// ImageSmallIconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imagesmalliconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageSmallIconUrl
            {
                get;
                set;
            }

            /// <summary>
            /// ImageUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageUrl
            {
                get;
                set;
            }

            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title
            {
                get;
                set;
            }

            /// <summary>
            /// ImageIconUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-imageiconurl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageIconUrl
            {
                get;
                set;
            }

            /// <summary>
            /// SilentPush
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-silentpush
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SilentPush
            {
                get;
                set;
            }

            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body
            {
                get;
                set;
            }

            /// <summary>
            /// RawContent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-rawcontent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RawContent
            {
                get;
                set;
            }

            /// <summary>
            /// Url
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-message.html#cfn-pinpoint-campaign-message-url
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Url
            {
                get;
                set;
            }
        }

        public class CampaignEventFilter
        {
            /// <summary>
            /// FilterType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigneventfilter.html#cfn-pinpoint-campaign-campaigneventfilter-filtertype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FilterType
            {
                get;
                set;
            }

            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaigneventfilter.html#cfn-pinpoint-campaign-campaigneventfilter-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EventDimensions
            /// </summary>
            public EventDimensions Dimensions
            {
                get;
                set;
            }
        }

        public class CampaignSmsMessage
        {
            /// <summary>
            /// SenderId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-senderid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SenderId
            {
                get;
                set;
            }

            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body
            {
                get;
                set;
            }

            /// <summary>
            /// MessageType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignsmsmessage.html#cfn-pinpoint-campaign-campaignsmsmessage-messagetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MessageType
            {
                get;
                set;
            }
        }

        public class CampaignEmailMessage
        {
            /// <summary>
            /// FromAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-fromaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FromAddress
            {
                get;
                set;
            }

            /// <summary>
            /// HtmlBody
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-htmlbody
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HtmlBody
            {
                get;
                set;
            }

            /// <summary>
            /// Title
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-title
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Title
            {
                get;
                set;
            }

            /// <summary>
            /// Body
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-campaignemailmessage.html#cfn-pinpoint-campaign-campaignemailmessage-body
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Body
            {
                get;
                set;
            }
        }

        public class WriteTreatmentResource
        {
            /// <summary>
            /// TreatmentDescription
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-treatmentdescription
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreatmentDescription
            {
                get;
                set;
            }

            /// <summary>
            /// MessageConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-messageconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MessageConfiguration
            /// </summary>
            public MessageConfiguration MessageConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// Schedule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-schedule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Schedule
            /// </summary>
            public Schedule Schedule
            {
                get;
                set;
            }

            /// <summary>
            /// SizePercent
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-sizepercent
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizePercent
            {
                get;
                set;
            }

            /// <summary>
            /// TreatmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpoint-campaign-writetreatmentresource.html#cfn-pinpoint-campaign-writetreatmentresource-treatmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TreatmentName
            {
                get;
                set;
            }
        }
    }
}