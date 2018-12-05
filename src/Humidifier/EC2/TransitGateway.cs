namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class TransitGateway : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TransitGateway";
            }
        }

        /// <summary>
        /// DefaultRouteTablePropagation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-defaultroutetablepropagation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultRouteTablePropagation
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// AutoAcceptSharedAttachments
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-autoacceptsharedattachments
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoAcceptSharedAttachments
        {
            get;
            set;
        }

        /// <summary>
        /// DefaultRouteTableAssociation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-defaultroutetableassociation
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DefaultRouteTableAssociation
        {
            get;
            set;
        }

        /// <summary>
        /// VpnEcmpSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-vpnecmpsupport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpnEcmpSupport
        {
            get;
            set;
        }

        /// <summary>
        /// DnsSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-dnssupport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DnsSupport
        {
            get;
            set;
        }

        /// <summary>
        /// AmazonSideAsn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-amazonsideasn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic AmazonSideAsn
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-transitgateway.html#cfn-ec2-transitgateway-tags
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