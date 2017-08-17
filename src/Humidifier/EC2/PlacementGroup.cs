namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using PlacementGroupPropertyTypes;

    public class PlacementGroup : Humidifier.Resource
    {
        /// <summary>
        /// Strategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html#cfn-ec2-placementgroup-strategy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Strategy
        {
            get;
            set;
        }
    }

    namespace PlacementGroupPropertyTypes
    {
    }
}