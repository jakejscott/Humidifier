namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class ClientVpnTargetNetworkAssociation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::ClientVpnTargetNetworkAssociation";
            }
        }

        /// <summary>
        /// ClientVpnEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpntargetnetworkassociation.html#cfn-ec2-clientvpntargetnetworkassociation-clientvpnendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientVpnEndpointId
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpntargetnetworkassociation.html#cfn-ec2-clientvpntargetnetworkassociation-subnetid
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
}