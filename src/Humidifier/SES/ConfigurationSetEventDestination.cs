namespace Humidifier.SES
{
    using System.Collections.Generic;
    using ConfigurationSetEventDestinationTypes;

    public class ConfigurationSetEventDestination : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SES::ConfigurationSetEventDestination";
            }
        }

        /// <summary>
        /// ConfigurationSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html#cfn-ses-configurationseteventdestination-configurationsetname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConfigurationSetName
        {
            get;
            set;
        }

        /// <summary>
        /// EventDestination
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-configurationseteventdestination.html#cfn-ses-configurationseteventdestination-eventdestination
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EventDestination
        /// </summary>
        public EventDestination EventDestination
        {
            get;
            set;
        }
    }

    namespace ConfigurationSetEventDestinationTypes
    {
        public class EventDestination
        {
            /// <summary>
            /// CloudWatchDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html#cfn-ses-configurationseteventdestination-eventdestination-cloudwatchdestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchDestination
            /// </summary>
            public CloudWatchDestination CloudWatchDestination
            {
                get;
                set;
            }

            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html#cfn-ses-configurationseteventdestination-eventdestination-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }

            /// <summary>
            /// MatchingEventTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html#cfn-ses-configurationseteventdestination-eventdestination-matchingeventtypes
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic MatchingEventTypes
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html#cfn-ses-configurationseteventdestination-eventdestination-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// KinesisFirehoseDestination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-eventdestination.html#cfn-ses-configurationseteventdestination-eventdestination-kinesisfirehosedestination
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseDestination
            /// </summary>
            public KinesisFirehoseDestination KinesisFirehoseDestination
            {
                get;
                set;
            }
        }

        public class CloudWatchDestination
        {
            /// <summary>
            /// DimensionConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-cloudwatchdestination.html#cfn-ses-configurationseteventdestination-cloudwatchdestination-dimensionconfigurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DimensionConfiguration
            /// </summary>
            public List<DimensionConfiguration> DimensionConfigurations
            {
                get;
                set;
            }
        }

        public class KinesisFirehoseDestination
        {
            /// <summary>
            /// IAMRoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-kinesisfirehosedestination.html#cfn-ses-configurationseteventdestination-kinesisfirehosedestination-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IAMRoleARN
            {
                get;
                set;
            }

            /// <summary>
            /// DeliveryStreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-kinesisfirehosedestination.html#cfn-ses-configurationseteventdestination-kinesisfirehosedestination-deliverystreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeliveryStreamARN
            {
                get;
                set;
            }
        }

        public class DimensionConfiguration
        {
            /// <summary>
            /// DimensionValueSource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-dimensionconfiguration.html#cfn-ses-configurationseteventdestination-dimensionconfiguration-dimensionvaluesource
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionValueSource
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultDimensionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-dimensionconfiguration.html#cfn-ses-configurationseteventdestination-dimensionconfiguration-defaultdimensionvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultDimensionValue
            {
                get;
                set;
            }

            /// <summary>
            /// DimensionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-configurationseteventdestination-dimensionconfiguration.html#cfn-ses-configurationseteventdestination-dimensionconfiguration-dimensionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DimensionName
            {
                get;
                set;
            }
        }
    }
}