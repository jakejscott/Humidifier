using System.Collections.Generic;
using Humidifier.Serverless.SimpleTableTypes;

namespace Humidifier.Serverless
{
    public class SimpleTable : Resource
    {
        public override string AWSTypeName => "AWS::Serverless::SimpleTable";

        /// <summary>
        /// Attribute name and type to be used as the table's primary key. This cannot be modified without replacing the resource. Defaults to String attribute named ID.
        /// </summary>
        public PrimaryKey PrimaryKey { get; set; }

        /// <summary>
        /// Read and write throughput provisioning information. Defaults to 5 read and 5 write capacity units per second.
        /// </summary>
        public ProvisionedThroughput ProvisionedThroughput { get; set; }
        
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-function.html#cfn-lambda-function-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags { get; set; }

        /// <summary>
        /// Name for the DynamoDB Table
        /// </summary>
        public string TableName { get; set; }
    }

    namespace SimpleTableTypes
    {
        public class PrimaryKey
        {
            /// <summary>
            /// Attribute name of the primary key. Defaults to id.
            /// Type: String
            /// </summary>
            public dynamic Name { get; set; }

            /// <summary>
            /// Attribute type of the primary key. MUST be one of String, Number, or Binary.
            /// Type: String
            /// </summary>
            public dynamic Type { get; set; }
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
            public dynamic ReadCapacityUnits { get; set; }

            /// <summary>
            /// WriteCapacityUnits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dynamodb-provisionedthroughput.html#cfn-dynamodb-provisionedthroughput-writecapacityunits
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic WriteCapacityUnits { get; set; }
        }
    }
}