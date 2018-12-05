namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayRoute : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGatewayRoute";
            }
        }

        /// <summary>
        /// TransitGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroute.html#cfn-ec2-transitgatewayroute-transitgatewayroutetableid
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
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroute.html#cfn-ec2-transitgatewayroute-destinationcidrblock
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationCidrBlock
        {
            get;
            set;
        }

        /// <summary>
        /// Blackhole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroute.html#cfn-ec2-transitgatewayroute-blackhole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Blackhole
        {
            get;
            set;
        }

        /// <summary>
        /// TransitGatewayAttachmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroute.html#cfn-ec2-transitgatewayroute-transitgatewayattachmentid
        /// Required: False
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