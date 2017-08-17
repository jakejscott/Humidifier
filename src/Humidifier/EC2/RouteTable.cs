namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using RouteTablePropertyTypes;

    public class RouteTable : Humidifier.Resource
    {
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html#cfn-ec2-routetable-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-route-table.html#cfn-ec2-routetable-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId
        {
            get;
            set;
        }
    }

    namespace RouteTablePropertyTypes
    {
    }
}