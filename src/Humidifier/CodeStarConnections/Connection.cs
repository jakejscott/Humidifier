namespace Humidifier.CodeStarConnections
{
    using System.Collections.Generic;

    public class Connection : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string ConnectionArn =  "ConnectionArn" ;
            public static string ConnectionStatus =  "ConnectionStatus" ;
            public static string OwnerAccountId =  "OwnerAccountId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CodeStarConnections::Connection";
            }
        }

        /// <summary>
        /// ConnectionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-connectionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ConnectionName
        {
            get;
            set;
        }

        /// <summary>
        /// ProviderType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codestarconnections-connection.html#cfn-codestarconnections-connection-providertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ProviderType
        {
            get;
            set;
        }
    }
}