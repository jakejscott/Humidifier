namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayRouteTable : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGatewayRouteTable";
            }
        }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetable.html#cfn-ec2-transitgatewayroutetable-transitgatewayid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TransitGatewayId
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayroutetable.html#cfn-ec2-transitgatewayroutetable-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }
}