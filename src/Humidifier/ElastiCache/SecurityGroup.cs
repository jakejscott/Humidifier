namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;
    using SecurityGroupPropertyTypes;

    public class SecurityGroup : Humidifier.Resource
    {
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-security-group.html#cfn-elasticache-securitygroup-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }
    }

    namespace SecurityGroupPropertyTypes
    {
    }
}