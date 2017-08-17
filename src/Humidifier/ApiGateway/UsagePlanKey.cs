namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using UsagePlanKeyPropertyTypes;

    public class UsagePlanKey : IResource
    {
        /// <summary>
        /// KeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-keyid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyId
        {
            get;
            set;
        }

        /// <summary>
        /// KeyType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-keytype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyType
        {
            get;
            set;
        }

        /// <summary>
        /// UsagePlanId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplankey.html#cfn-apigateway-usageplankey-usageplanid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UsagePlanId
        {
            get;
            set;
        }
    }

    namespace UsagePlanKeyPropertyTypes
    {
    }
}