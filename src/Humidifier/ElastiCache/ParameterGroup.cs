namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;
    using ParameterGroupPropertyTypes;

    public class ParameterGroup : Humidifier.Resource
    {
        /// <summary>
        /// CacheParameterGroupFamily
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-cacheparametergroupfamily
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheParameterGroupFamily
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-description
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
        /// Properties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-parameter-group.html#cfn-elasticache-parametergroup-properties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Properties
        {
            get;
            set;
        }
    }

    namespace ParameterGroupPropertyTypes
    {
    }
}