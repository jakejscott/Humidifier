namespace Humidifier.DynamoDB
{
    using System.Collections.Generic;
    using TableTypes;

    public class Table : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string StreamArn =  "StreamArn" ;
        }

        /// <summary>
        /// AttributeDefinitions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-attributedef
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: AttributeDefinition
        /// </summary>
        public List<AttributeDefinition> AttributeDefinitions
        {
            get;
            set;
        }

        /// <summary>
        /// GlobalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-gsi
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: GlobalSecondaryIndex
        /// </summary>
        public List<GlobalSecondaryIndex> GlobalSecondaryIndexes
        {
            get;
            set;
        }

        /// <summary>
        /// KeySchema
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-keyschema
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: KeySchema
        /// </summary>
        public List<KeySchema> KeySchema
        {
            get;
            set;
        }

        /// <summary>
        /// LocalSecondaryIndexes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-lsi
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: LocalSecondaryIndex
        /// </summary>
        public List<LocalSecondaryIndex> LocalSecondaryIndexes
        {
            get;
            set;
        }

        /// <summary>
        /// ProvisionedThroughput
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-provisionedthroughput
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ProvisionedThroughput
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput
        {
            get;
            set;
        }

        /// <summary>
        /// SSESpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-ssespecification
        /// Required: False
        /// UpdateType: Conditional
        /// Type: SSESpecification
        /// </summary>
        public SSESpecification SSESpecification
        {
            get;
            set;
        }

        /// <summary>
        /// StreamSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-streamspecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: StreamSpecification
        /// </summary>
        public StreamSpecification StreamSpecification
        {
            get;
            set;
        }

        /// <summary>
        /// TableName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tablename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TableName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// TimeToLiveSpecification
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dynamodb-table.html#cfn-dynamodb-table-timetolivespecification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TimeToLiveSpecification
        /// </summary>
        public TimeToLiveSpecification TimeToLiveSpecification
        {
            get;
            set;
        }
    }

    namespace TableTypes
    {
        public class TimeToLiveSpecification
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-timetolivespecification.html#cfn-dynamodb-timetolivespecification-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName
            {
                get;
                set;
            }

            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-timetolivespecification.html#cfn-dynamodb-timetolivespecification-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }
        }

        public class AttributeDefinition
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-attributedef.html#cfn-dynamodb-attributedef-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName
            {
                get;
                set;
            }

            /// <summary>
            /// AttributeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-attributedef.html#cfn-dynamodb-attributedef-attributename-attributetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeType
            {
                get;
                set;
            }
        }

        public class LocalSecondaryIndex
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-indexname
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
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema
            {
                get;
                set;
            }

            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-lsi.html#cfn-dynamodb-lsi-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Projection Projection
            {
                get;
                set;
            }
        }

        public class ProvisionedThroughput
        {
            /// <summary>
            /// ReadCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-provisionedthroughput.html#cfn-dynamodb-provisionedthroughput-readcapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic ReadCapacityUnits
            {
                get;
                set;
            }

            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-provisionedthroughput.html#cfn-dynamodb-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic WriteCapacityUnits
            {
                get;
                set;
            }
        }

        public class GlobalSecondaryIndex
        {
            /// <summary>
            /// IndexName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-gsi.html#cfn-dynamodb-gsi-indexname
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
            /// KeySchema
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-gsi.html#cfn-dynamodb-gsi-keyschema
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: KeySchema
            /// </summary>
            public List<KeySchema> KeySchema
            {
                get;
                set;
            }

            /// <summary>
            /// Projection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-gsi.html#cfn-dynamodb-gsi-projection
            /// Required: True
            /// UpdateType: Mutable
            /// Type: Projection
            /// </summary>
            public Projection Projection
            {
                get;
                set;
            }

            /// <summary>
            /// ProvisionedThroughput
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-gsi.html#cfn-dynamodb-gsi-provisionedthroughput
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ProvisionedThroughput
            /// </summary>
            public ProvisionedThroughput ProvisionedThroughput
            {
                get;
                set;
            }
        }

        public class KeySchema
        {
            /// <summary>
            /// AttributeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-keyschema.html#aws-properties-dynamodb-keyschema-attributename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AttributeName
            {
                get;
                set;
            }

            /// <summary>
            /// KeyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-keyschema.html#aws-properties-dynamodb-keyschema-keytype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyType
            {
                get;
                set;
            }
        }

        public class Projection
        {
            /// <summary>
            /// NonKeyAttributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-projectionobject.html#cfn-dynamodb-projectionobj-nonkeyatt
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic NonKeyAttributes
            {
                get;
                set;
            }

            /// <summary>
            /// ProjectionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-projectionobject.html#cfn-dynamodb-projectionobj-projtype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ProjectionType
            {
                get;
                set;
            }
        }

        public class SSESpecification
        {
            /// <summary>
            /// SSEEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-table-ssespecification.html#cfn-dynamodb-table-ssespecification-sseenabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SSEEnabled
            {
                get;
                set;
            }
        }

        public class StreamSpecification
        {
            /// <summary>
            /// StreamViewType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-streamspecification.html#cfn-dynamodb-streamspecification-streamviewtype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StreamViewType
            {
                get;
                set;
            }
        }
    }
}