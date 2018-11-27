namespace Humidifier.SecretsManager
{
    using System.Collections.Generic;

    public class ResourcePolicy : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecretsManager::ResourcePolicy";
            }
        }

        /// <summary>
        /// SecretId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-resourcepolicy.html#cfn-secretsmanager-resourcepolicy-secretid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecretId
        {
            get;
            set;
        }

        /// <summary>
        /// ResourcePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-resourcepolicy.html#cfn-secretsmanager-resourcepolicy-resourcepolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic ResourcePolicy_
        {
            get;
            set;
        }
    }
}