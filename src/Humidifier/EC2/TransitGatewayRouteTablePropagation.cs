namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayRouteTablePropagation : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGatewayRouteTablePropagation";
            }
        }

        /// <summary>
        /// TransitGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayroutetableid
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetablepropagation.html#cfn-ec2-transitgatewayroutetablepropagation-transitgatewayattachmentid
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