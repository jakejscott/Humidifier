namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using TrunkInterfaceAssociationPropertyTypes;

    public class TrunkInterfaceAssociation : IResource
    {
        /// <summary>
        /// BranchInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-branchinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BranchInterfaceId
        {
            get;
            set;
        }

        /// <summary>
        /// GREKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-grekey
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? GREKey
        {
            get;
            set;
        }

        /// <summary>
        /// TrunkInterfaceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-trunkinterfaceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrunkInterfaceId
        {
            get;
            set;
        }

        /// <summary>
        /// VLANId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trunkinterfaceassociation.html#cfn-ec2-trunkinterfaceassociation-vlanid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? VLANId
        {
            get;
            set;
        }
    }

    namespace TrunkInterfaceAssociationPropertyTypes
    {
    }
}