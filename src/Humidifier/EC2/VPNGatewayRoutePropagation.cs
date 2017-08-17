namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VPNGatewayRoutePropagationPropertyTypes;

    public class VPNGatewayRoutePropagation : IResource
    {
        /// <summary>
        /// RouteTableIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html#cfn-ec2-vpngatewayrouteprop-routetableids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> RouteTableIds
        {
            get;
            set;
        }

        /// <summary>
        /// VpnGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpn-gatewayrouteprop.html#cfn-ec2-vpngatewayrouteprop-vpngatewayid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpnGatewayId
        {
            get;
            set;
        }
    }

    namespace VPNGatewayRoutePropagationPropertyTypes
    {
    }
}