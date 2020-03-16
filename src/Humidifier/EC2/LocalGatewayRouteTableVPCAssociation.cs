namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using LocalGatewayRouteTableVPCAssociationTypes;

    public class LocalGatewayRouteTableVPCAssociation : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string LocalGatewayId =  "LocalGatewayId" ;
            public static string LocalGatewayRouteTableVpcAssociationId =  "LocalGatewayRouteTableVpcAssociationId" ;
            public static string State =  "State" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::LocalGatewayRouteTableVPCAssociation";
            }
        }

        /// <summary>
        /// LocalGatewayRouteTableId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-localgatewayroutetableid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LocalGatewayRouteTableId
        {
            get;
            set;
        }

        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-vpcid
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
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-localgatewayroutetablevpcassociation.html#cfn-ec2-localgatewayroutetablevpcassociation-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Tags
        /// </summary>
        public Tags Tags
        {
            get;
            set;
        }
    }

    namespace LocalGatewayRouteTableVPCAssociationTypes
    {
        public class Tags
        {
            /// <summary>
            /// Tags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-localgatewayroutetablevpcassociation-tags.html#cfn-ec2-localgatewayroutetablevpcassociation-tags-tags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> Tags_
            {
                get;
                set;
            }
        }
    }
}