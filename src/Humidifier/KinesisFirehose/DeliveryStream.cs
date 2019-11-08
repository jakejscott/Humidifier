namespace Humidifier.KinesisFirehose
{
    using System.Collections.Generic;
    using DeliveryStreamTypes;

    public class DeliveryStream : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::KinesisFirehose::DeliveryStream";
            }
        }

        /// <summary>
        /// DeliveryStreamName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryStreamName
        {
            get;
            set;
        }

        /// <summary>
        /// DeliveryStreamType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-deliverystreamtype
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeliveryStreamType
        {
            get;
            set;
        }

        /// <summary>
        /// ElasticsearchDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ElasticsearchDestinationConfiguration
        /// </summary>
        public ElasticsearchDestinationConfiguration ElasticsearchDestinationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// ExtendedS3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ExtendedS3DestinationConfiguration
        /// </summary>
        public ExtendedS3DestinationConfiguration ExtendedS3DestinationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// KinesisStreamSourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: KinesisStreamSourceConfiguration
        /// </summary>
        public KinesisStreamSourceConfiguration KinesisStreamSourceConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// RedshiftDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RedshiftDestinationConfiguration
        /// </summary>
        public RedshiftDestinationConfiguration RedshiftDestinationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// S3DestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: S3DestinationConfiguration
        /// </summary>
        public S3DestinationConfiguration S3DestinationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// SplunkDestinationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisfirehose-deliverystream.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SplunkDestinationConfiguration
        /// </summary>
        public SplunkDestinationConfiguration SplunkDestinationConfiguration
        {
            get;
            set;
        }
    }

    namespace DeliveryStreamTypes
    {
        public class OrcSerDe
        {
            /// <summary>
            /// BlockSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-blocksizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockSizeBytes
            {
                get;
                set;
            }

            /// <summary>
            /// BloomFilterColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-bloomfiltercolumns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BloomFilterColumns
            {
                get;
                set;
            }

            /// <summary>
            /// BloomFilterFalsePositiveProbability
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-bloomfilterfalsepositiveprobability
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BloomFilterFalsePositiveProbability
            {
                get;
                set;
            }

            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Compression
            {
                get;
                set;
            }

            /// <summary>
            /// DictionaryKeyThreshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-dictionarykeythreshold
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DictionaryKeyThreshold
            {
                get;
                set;
            }

            /// <summary>
            /// EnablePadding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-enablepadding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnablePadding
            {
                get;
                set;
            }

            /// <summary>
            /// FormatVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-formatversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FormatVersion
            {
                get;
                set;
            }

            /// <summary>
            /// PaddingTolerance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-paddingtolerance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PaddingTolerance
            {
                get;
                set;
            }

            /// <summary>
            /// RowIndexStride
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-rowindexstride
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RowIndexStride
            {
                get;
                set;
            }

            /// <summary>
            /// StripeSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-orcserde.html#cfn-kinesisfirehose-deliverystream-orcserde-stripesizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic StripeSizeBytes
            {
                get;
                set;
            }
        }

        public class ElasticsearchBufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchbufferinghints.html#cfn-kinesisfirehose-deliverystream-elasticsearchbufferinghints-intervalinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds
            {
                get;
                set;
            }

            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchbufferinghints.html#cfn-kinesisfirehose-deliverystream-elasticsearchbufferinghints-sizeinmbs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs
            {
                get;
                set;
            }
        }

        public class SplunkDestinationConfiguration
        {
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions
            {
                get;
                set;
            }

            /// <summary>
            /// HECAcknowledgmentTimeoutInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecacknowledgmenttimeoutinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HECAcknowledgmentTimeoutInSeconds
            {
                get;
                set;
            }

            /// <summary>
            /// HECEndpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecendpoint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECEndpoint
            {
                get;
                set;
            }

            /// <summary>
            /// HECEndpointType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hecendpointtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECEndpointType
            {
                get;
                set;
            }

            /// <summary>
            /// HECToken
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-hectoken
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HECToken
            {
                get;
                set;
            }

            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-retryoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SplunkRetryOptions
            /// </summary>
            public SplunkRetryOptions RetryOptions
            {
                get;
                set;
            }

            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode
            {
                get;
                set;
            }

            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-splunkdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration
            {
                get;
                set;
            }
        }

        public class EncryptionConfiguration
        {
            /// <summary>
            /// KMSEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html#cfn-kinesisfirehose-deliverystream-encryptionconfiguration-kmsencryptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KMSEncryptionConfig
            /// </summary>
            public KMSEncryptionConfig KMSEncryptionConfig
            {
                get;
                set;
            }

            /// <summary>
            /// NoEncryptionConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-encryptionconfiguration.html#cfn-kinesisfirehose-deliverystream-encryptionconfiguration-noencryptionconfig
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoEncryptionConfig
            {
                get;
                set;
            }
        }

        public class CloudWatchLoggingOptions
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-enabled
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
            /// LogGroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-loggroupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogGroupName
            {
                get;
                set;
            }

            /// <summary>
            /// LogStreamName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-cloudwatchloggingoptions.html#cfn-kinesisfirehose-deliverystream-cloudwatchloggingoptions-logstreamname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogStreamName
            {
                get;
                set;
            }
        }

        public class InputFormatConfiguration
        {
            /// <summary>
            /// Deserializer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-inputformatconfiguration.html#cfn-kinesisfirehose-deliverystream-inputformatconfiguration-deserializer
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Deserializer
            /// </summary>
            public Deserializer Deserializer
            {
                get;
                set;
            }
        }

        public class ProcessingConfiguration
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processingconfiguration.html#cfn-kinesisfirehose-deliverystream-processingconfiguration-enabled
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
            /// Processors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processingconfiguration.html#cfn-kinesisfirehose-deliverystream-processingconfiguration-processors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Processor
            /// </summary>
            public List<Processor> Processors
            {
                get;
                set;
            }
        }

        public class BufferingHints
        {
            /// <summary>
            /// IntervalInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-bufferinghints.html#cfn-kinesisfirehose-deliverystream-bufferinghints-intervalinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic IntervalInSeconds
            {
                get;
                set;
            }

            /// <summary>
            /// SizeInMBs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-bufferinghints.html#cfn-kinesisfirehose-deliverystream-bufferinghints-sizeinmbs
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInMBs
            {
                get;
                set;
            }
        }

        public class ProcessorParameter
        {
            /// <summary>
            /// ParameterName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processorparameter.html#cfn-kinesisfirehose-deliverystream-processorparameter-parametername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterName
            {
                get;
                set;
            }

            /// <summary>
            /// ParameterValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processorparameter.html#cfn-kinesisfirehose-deliverystream-processorparameter-parametervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ParameterValue
            {
                get;
                set;
            }
        }

        public class HiveJsonSerDe
        {
            /// <summary>
            /// TimestampFormats
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-hivejsonserde.html#cfn-kinesisfirehose-deliverystream-hivejsonserde-timestampformats
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TimestampFormats
            {
                get;
                set;
            }
        }

        public class Processor
        {
            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html#cfn-kinesisfirehose-deliverystream-processor-parameters
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ProcessorParameter
            /// </summary>
            public List<ProcessorParameter> Parameters
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-processor.html#cfn-kinesisfirehose-deliverystream-processor-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }
        }

        public class ElasticsearchRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchretryoptions.html#cfn-kinesisfirehose-deliverystream-elasticsearchretryoptions-durationinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds
            {
                get;
                set;
            }
        }

        public class DataFormatConversionConfiguration
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }

            /// <summary>
            /// InputFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-inputformatconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InputFormatConfiguration
            /// </summary>
            public InputFormatConfiguration InputFormatConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// OutputFormatConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-outputformatconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: OutputFormatConfiguration
            /// </summary>
            public OutputFormatConfiguration OutputFormatConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// SchemaConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-dataformatconversionconfiguration.html#cfn-kinesisfirehose-deliverystream-dataformatconversionconfiguration-schemaconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SchemaConfiguration
            /// </summary>
            public SchemaConfiguration SchemaConfiguration
            {
                get;
                set;
            }
        }

        public class KMSEncryptionConfig
        {
            /// <summary>
            /// AWSKMSKeyARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kmsencryptionconfig.html#cfn-kinesisfirehose-deliverystream-kmsencryptionconfig-awskmskeyarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AWSKMSKeyARN
            {
                get;
                set;
            }
        }

        public class OutputFormatConfiguration
        {
            /// <summary>
            /// Serializer
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-outputformatconfiguration.html#cfn-kinesisfirehose-deliverystream-outputformatconfiguration-serializer
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Serializer
            /// </summary>
            public Serializer Serializer
            {
                get;
                set;
            }
        }

        public class ElasticsearchDestinationConfiguration
        {
            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-bufferinghints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ElasticsearchBufferingHints
            /// </summary>
            public ElasticsearchBufferingHints BufferingHints
            {
                get;
                set;
            }

            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions
            {
                get;
                set;
            }

            /// <summary>
            /// DomainARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-domainarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainARN
            {
                get;
                set;
            }

            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-indexname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexName
            {
                get;
                set;
            }

            /// <summary>
            /// IndexRotationPeriod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-indexrotationperiod
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexRotationPeriod
            {
                get;
                set;
            }

            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// RetryOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-retryoptions
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ElasticsearchRetryOptions
            /// </summary>
            public ElasticsearchRetryOptions RetryOptions
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }

            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-s3backupmode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode
            {
                get;
                set;
            }

            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration
            {
                get;
                set;
            }

            /// <summary>
            /// TypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-elasticsearchdestinationconfiguration-typename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TypeName
            {
                get;
                set;
            }
        }

        public class SchemaConfiguration
        {
            /// <summary>
            /// CatalogId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-catalogid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogId
            {
                get;
                set;
            }

            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-databasename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName
            {
                get;
                set;
            }

            /// <summary>
            /// Region
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-region
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Region
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }

            /// <summary>
            /// TableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-tablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TableName
            {
                get;
                set;
            }

            /// <summary>
            /// VersionId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-schemaconfiguration.html#cfn-kinesisfirehose-deliverystream-schemaconfiguration-versionid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VersionId
            {
                get;
                set;
            }
        }

        public class SplunkRetryOptions
        {
            /// <summary>
            /// DurationInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-splunkretryoptions.html#cfn-kinesisfirehose-deliverystream-splunkretryoptions-durationinseconds
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DurationInSeconds
            {
                get;
                set;
            }
        }

        public class Deserializer
        {
            /// <summary>
            /// HiveJsonSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deserializer.html#cfn-kinesisfirehose-deliverystream-deserializer-hivejsonserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: HiveJsonSerDe
            /// </summary>
            public HiveJsonSerDe HiveJsonSerDe
            {
                get;
                set;
            }

            /// <summary>
            /// OpenXJsonSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-deserializer.html#cfn-kinesisfirehose-deliverystream-deserializer-openxjsonserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OpenXJsonSerDe
            /// </summary>
            public OpenXJsonSerDe OpenXJsonSerDe
            {
                get;
                set;
            }
        }

        public class KinesisStreamSourceConfiguration
        {
            /// <summary>
            /// KinesisStreamARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-kinesisstreamarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KinesisStreamARN
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration.html#cfn-kinesisfirehose-deliverystream-kinesisstreamsourceconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }
        }

        public class ParquetSerDe
        {
            /// <summary>
            /// BlockSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-blocksizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockSizeBytes
            {
                get;
                set;
            }

            /// <summary>
            /// Compression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-compression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Compression
            {
                get;
                set;
            }

            /// <summary>
            /// EnableDictionaryCompression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-enabledictionarycompression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableDictionaryCompression
            {
                get;
                set;
            }

            /// <summary>
            /// MaxPaddingBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-maxpaddingbytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxPaddingBytes
            {
                get;
                set;
            }

            /// <summary>
            /// PageSizeBytes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-pagesizebytes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic PageSizeBytes
            {
                get;
                set;
            }

            /// <summary>
            /// WriterVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-parquetserde.html#cfn-kinesisfirehose-deliverystream-parquetserde-writerversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WriterVersion
            {
                get;
                set;
            }
        }

        public class Serializer
        {
            /// <summary>
            /// OrcSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-serializer.html#cfn-kinesisfirehose-deliverystream-serializer-orcserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: OrcSerDe
            /// </summary>
            public OrcSerDe OrcSerDe
            {
                get;
                set;
            }

            /// <summary>
            /// ParquetSerDe
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-serializer.html#cfn-kinesisfirehose-deliverystream-serializer-parquetserde
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ParquetSerDe
            /// </summary>
            public ParquetSerDe ParquetSerDe
            {
                get;
                set;
            }
        }

        public class CopyCommand
        {
            /// <summary>
            /// CopyOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-copyoptions
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CopyOptions
            {
                get;
                set;
            }

            /// <summary>
            /// DataTableColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-datatablecolumns
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTableColumns
            {
                get;
                set;
            }

            /// <summary>
            /// DataTableName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-copycommand.html#cfn-kinesisfirehose-deliverystream-copycommand-datatablename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataTableName
            {
                get;
                set;
            }
        }

        public class OpenXJsonSerDe
        {
            /// <summary>
            /// CaseInsensitive
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-caseinsensitive
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CaseInsensitive
            {
                get;
                set;
            }

            /// <summary>
            /// ColumnToJsonKeyMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-columntojsonkeymappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ColumnToJsonKeyMappings
            {
                get;
                set;
            }

            /// <summary>
            /// ConvertDotsInJsonKeysToUnderscores
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-openxjsonserde.html#cfn-kinesisfirehose-deliverystream-openxjsonserde-convertdotsinjsonkeystounderscores
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ConvertDotsInJsonKeysToUnderscores
            {
                get;
                set;
            }
        }

        public class S3DestinationConfiguration
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN
            {
                get;
                set;
            }

            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-bufferinghints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BufferingHints
            /// </summary>
            public BufferingHints BufferingHints
            {
                get;
                set;
            }

            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions
            {
                get;
                set;
            }

            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-compressionformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionFormat
            {
                get;
                set;
            }

            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-erroroutputprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-s3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-s3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }
        }

        public class ExtendedS3DestinationConfiguration
        {
            /// <summary>
            /// BucketARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-bucketarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BucketARN
            {
                get;
                set;
            }

            /// <summary>
            /// BufferingHints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-bufferinghints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: BufferingHints
            /// </summary>
            public BufferingHints BufferingHints
            {
                get;
                set;
            }

            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions
            {
                get;
                set;
            }

            /// <summary>
            /// CompressionFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-compressionformat
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CompressionFormat
            {
                get;
                set;
            }

            /// <summary>
            /// DataFormatConversionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-dataformatconversionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DataFormatConversionConfiguration
            /// </summary>
            public DataFormatConversionConfiguration DataFormatConversionConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// EncryptionConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-encryptionconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionConfiguration
            /// </summary>
            public EncryptionConfiguration EncryptionConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// ErrorOutputPrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-erroroutputprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorOutputPrefix
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }

            /// <summary>
            /// S3BackupConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-s3backupconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3BackupConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// S3BackupMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-extendeds3destinationconfiguration.html#cfn-kinesisfirehose-deliverystream-extendeds3destinationconfiguration-s3backupmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3BackupMode
            {
                get;
                set;
            }
        }

        public class RedshiftDestinationConfiguration
        {
            /// <summary>
            /// CloudWatchLoggingOptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-cloudwatchloggingoptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchLoggingOptions
            /// </summary>
            public CloudWatchLoggingOptions CloudWatchLoggingOptions
            {
                get;
                set;
            }

            /// <summary>
            /// ClusterJDBCURL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-clusterjdbcurl
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ClusterJDBCURL
            {
                get;
                set;
            }

            /// <summary>
            /// CopyCommand
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-copycommand
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CopyCommand
            /// </summary>
            public CopyCommand CopyCommand
            {
                get;
                set;
            }

            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-password
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Password
            {
                get;
                set;
            }

            /// <summary>
            /// ProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-processingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ProcessingConfiguration
            /// </summary>
            public ProcessingConfiguration ProcessingConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-rolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RoleARN
            {
                get;
                set;
            }

            /// <summary>
            /// S3Configuration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-s3configuration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3DestinationConfiguration
            /// </summary>
            public S3DestinationConfiguration S3Configuration
            {
                get;
                set;
            }

            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisfirehose-deliverystream-redshiftdestinationconfiguration.html#cfn-kinesisfirehose-deliverystream-redshiftdestinationconfiguration-username
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username
            {
                get;
                set;
            }
        }
    }
}