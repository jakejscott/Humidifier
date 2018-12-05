namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGatewayAttachment : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGatewayAttachment";
            }
        }

        /// <summary>
        /// TransitGatewayId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-transitgatewayid
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
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-subnetids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SubnetIds
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgatewayattachment.html#cfn-ec2-transitgatewayattachment-tags
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