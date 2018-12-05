namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayRouteTableAssociation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGatewayRouteTableAssociation";
            }
        }

        /// <summary>
        /// TransitGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetableassociation.html#cfn-ec2-transitgatewayroutetableassociation-transitgatewayroutetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransitGatewayRouteTableId
        {
            get;
            set;
        }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetableassociation.html#cfn-ec2-transitgatewayroutetableassociation-transitgatewayattachmentid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransitGatewayAttachmentId
        {
            get;
            set;
        }
    }
}