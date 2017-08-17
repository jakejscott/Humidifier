namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;
    using SubnetGroupPropertyTypes;

    public class SubnetGroup : Humidifier.Resource
    {
        /// <summary>
        /// CacheSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-cachesubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-subnetgroup.html#cfn-elasticache-subnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> SubnetIds
        {
            get;
            set;
        }
    }

    namespace SubnetGroupPropertyTypes
    {
    }
}