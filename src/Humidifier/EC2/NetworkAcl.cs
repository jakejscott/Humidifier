namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using NetworkAclPropertyTypes;

    public class NetworkAcl : Humidifier.Resource
    {
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl.html#cfn-ec2-networkacl-tags
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-network-acl.html#cfn-ec2-networkacl-vpcid
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

    namespace NetworkAclPropertyTypes
    {
    }
}