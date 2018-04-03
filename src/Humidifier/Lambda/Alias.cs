namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using AliasTypes;

    public class Alias : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Lambda::Alias";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-description
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-functionname
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
        /// FunctionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-functionversion
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// RoutingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-alias.html#cfn-lambda-alias-routingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AliasRoutingConfiguration
        /// </summary>
        public AliasRoutingConfiguration RoutingConfig
        {
            get;
            set;
        }
    }

    namespace AliasTypes
    {
        public class AliasRoutingConfiguration
        {
            /// <summary>
            /// AdditionalVersionWeights
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-aliasroutingconfiguration.html#cfn-lambda-alias-aliasroutingconfiguration-additionalversionweights
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: VersionWeight
            /// </summary>
            public List<VersionWeight> AdditionalVersionWeights
            {
                get;
                set;
            }
        }

        public class VersionWeight
        {
            /// <summary>
            /// FunctionVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionVersion
            {
                get;
                set;
            }

            /// <summary>
            /// FunctionWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lambda-alias-versionweight.html#cfn-lambda-alias-versionweight-functionweight
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic FunctionWeight
            {
                get;
                set;
            }
        }
    }
}