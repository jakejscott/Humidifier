namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using VersionTypes;

    public class Version : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Version =  "Version" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lambda::Version";
            }
        }

        /// <summary>
        /// CodeSha256
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-codesha256
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeSha256
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-description
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
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-functionname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionName
        {
            get;
            set;
        }

        /// <summary>
        /// ProvisionedConcurrencyConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-version.html#cfn-lambda-version-provisionedconcurrencyconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ProvisionedConcurrencyConfiguration
        /// </summary>
        public ProvisionedConcurrencyConfiguration ProvisionedConcurrencyConfig
        {
            get;
            set;
        }
    }

    namespace VersionTypes
    {
        public class ProvisionedConcurrencyConfiguration
        {
            /// <summary>
            /// ProvisionedConcurrentExecutions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-version-provisionedconcurrencyconfiguration.html#cfn-lambda-version-provisionedconcurrencyconfiguration-provisionedconcurrentexecutions
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProvisionedConcurrentExecutions
            {
                get;
                set;
            }
        }
    }
}