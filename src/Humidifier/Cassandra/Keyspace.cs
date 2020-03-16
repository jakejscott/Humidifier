namespace Humidifier.Cassandra
{
    using System.Collections.Generic;

    public class Keyspace : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Cassandra::Keyspace";
            }
        }

        /// <summary>
        /// KeyspaceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cassandra-keyspace.html#cfn-cassandra-keyspace-keyspacename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyspaceName
        {
            get;
            set;
        }
    }
}