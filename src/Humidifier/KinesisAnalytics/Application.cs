namespace Humidifier.KinesisAnalytics
{
    using System.Collections.Generic;
    using ApplicationPropertyTypes;

    public class Application : Humidifier.Resource
    {
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName
        {
            get;
            set;
        }

        /// <summary>
        /// Inputs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-inputs
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Input
        /// </summary>
        public List<Input> Inputs
        {
            get;
            set;
        }

        /// <summary>
        /// ApplicationDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationDescription
        {
            get;
            set;
        }

        /// <summary>
        /// ApplicationCode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kinesisanalytics-application.html#cfn-kinesisanalytics-application-applicationcode
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationCode
        {
            get;
            set;
        }
    }

    namespace ApplicationPropertyTypes
    {
        public class MappingParameters
        {
            /// <summary>
            /// JSONMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-mappingparameters.html#cfn-kinesisanalytics-application-mappingparameters-jsonmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JSONMappingParameters
            /// </summary>
            public JSONMappingParameters JSONMappingParameters
            {
                get;
                set;
            }

            /// <summary>
            /// CSVMappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-mappingparameters.html#cfn-kinesisanalytics-application-mappingparameters-csvmappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CSVMappingParameters
            /// </summary>
            public CSVMappingParameters CSVMappingParameters
            {
                get;
                set;
            }
        }

        public class CSVMappingParameters
        {
            /// <summary>
            /// RecordRowDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-csvmappingparameters.html#cfn-kinesisanalytics-application-csvmappingparameters-recordrowdelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordRowDelimiter
            {
                get;
                set;
            }

            /// <summary>
            /// RecordColumnDelimiter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-csvmappingparameters.html#cfn-kinesisanalytics-application-csvmappingparameters-recordcolumndelimiter
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordColumnDelimiter
            {
                get;
                set;
            }
        }

        public class KinesisStreamsInput
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisstreamsinput.html#cfn-kinesisanalytics-application-kinesisstreamsinput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisstreamsinput.html#cfn-kinesisanalytics-application-kinesisstreamsinput-rolearn
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

        public class Input
        {
            /// <summary>
            /// NamePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-nameprefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NamePrefix
            {
                get;
                set;
            }

            /// <summary>
            /// InputSchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: InputSchema
            /// </summary>
            public InputSchema InputSchema
            {
                get;
                set;
            }

            /// <summary>
            /// KinesisStreamsInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisstreamsinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisStreamsInput
            /// </summary>
            public KinesisStreamsInput KinesisStreamsInput
            {
                get;
                set;
            }

            /// <summary>
            /// KinesisFirehoseInput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-kinesisfirehoseinput
            /// Required: False
            /// UpdateType: Mutable
            /// Type: KinesisFirehoseInput
            /// </summary>
            public KinesisFirehoseInput KinesisFirehoseInput
            {
                get;
                set;
            }

            /// <summary>
            /// InputProcessingConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputprocessingconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputProcessingConfiguration
            /// </summary>
            public InputProcessingConfiguration InputProcessingConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// InputParallelism
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-input.html#cfn-kinesisanalytics-application-input-inputparallelism
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputParallelism
            /// </summary>
            public InputParallelism InputParallelism
            {
                get;
                set;
            }
        }

        public class InputSchema
        {
            /// <summary>
            /// RecordEncoding
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputschema.html#cfn-kinesisanalytics-application-inputschema-recordencoding
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordEncoding
            {
                get;
                set;
            }

            /// <summary>
            /// RecordColumns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputschema.html#cfn-kinesisanalytics-application-inputschema-recordcolumns
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RecordColumn
            /// </summary>
            public List<RecordColumn> RecordColumns
            {
                get;
                set;
            }

            /// <summary>
            /// RecordFormat
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputschema.html#cfn-kinesisanalytics-application-inputschema-recordformat
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RecordFormat
            /// </summary>
            public RecordFormat RecordFormat
            {
                get;
                set;
            }
        }

        public class RecordColumn
        {
            /// <summary>
            /// Mapping
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordcolumn.html#cfn-kinesisanalytics-application-recordcolumn-mapping
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Mapping
            {
                get;
                set;
            }

            /// <summary>
            /// SqlType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordcolumn.html#cfn-kinesisanalytics-application-recordcolumn-sqltype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SqlType
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordcolumn.html#cfn-kinesisanalytics-application-recordcolumn-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class RecordFormat
        {
            /// <summary>
            /// MappingParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordformat.html#cfn-kinesisanalytics-application-recordformat-mappingparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MappingParameters
            /// </summary>
            public MappingParameters MappingParameters
            {
                get;
                set;
            }

            /// <summary>
            /// RecordFormatType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-recordformat.html#cfn-kinesisanalytics-application-recordformat-recordformattype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordFormatType
            {
                get;
                set;
            }
        }

        public class KinesisFirehoseInput
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisfirehoseinput.html#cfn-kinesisanalytics-application-kinesisfirehoseinput-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-kinesisfirehoseinput.html#cfn-kinesisanalytics-application-kinesisfirehoseinput-rolearn
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

        public class InputParallelism
        {
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputparallelism.html#cfn-kinesisanalytics-application-inputparallelism-count
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Count
            {
                get;
                set;
            }
        }

        public class InputProcessingConfiguration
        {
            /// <summary>
            /// InputLambdaProcessor
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputprocessingconfiguration.html#cfn-kinesisanalytics-application-inputprocessingconfiguration-inputlambdaprocessor
            /// Required: False
            /// UpdateType: Mutable
            /// Type: InputLambdaProcessor
            /// </summary>
            public InputLambdaProcessor InputLambdaProcessor
            {
                get;
                set;
            }
        }

        public class JSONMappingParameters
        {
            /// <summary>
            /// RecordRowPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-jsonmappingparameters.html#cfn-kinesisanalytics-application-jsonmappingparameters-recordrowpath
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RecordRowPath
            {
                get;
                set;
            }
        }

        public class InputLambdaProcessor
        {
            /// <summary>
            /// ResourceARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputlambdaprocessor.html#cfn-kinesisanalytics-application-inputlambdaprocessor-resourcearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceARN
            {
                get;
                set;
            }

            /// <summary>
            /// RoleARN
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-kinesisanalytics-application-inputlambdaprocessor.html#cfn-kinesisanalytics-application-inputlambdaprocessor-rolearn
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
    }
}