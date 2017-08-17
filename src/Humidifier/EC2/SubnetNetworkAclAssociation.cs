namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using SubnetNetworkAclAssociationPropertyTypes;

    public class SubnetNetworkAclAssociation : Humidifier.Resource
    {
        /// <summary>
        /// NetworkAclId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html#cfn-ec2-subnetnetworkaclassociation-networkaclid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkAclId
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-subnet-network-acl-assoc.html#cfn-ec2-subnetnetworkaclassociation-associationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SubnetId
        {
            get;
            set;
        }
    }

    namespace SubnetNetworkAclAssociationPropertyTypes
    {
    }
}