namespace Humidifier.Route53Resolver
{
    using System.Collections.Generic;
    using ResolverEndpointTypes;

    public class ResolverEndpoint : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string ResolverEndpointId =  "ResolverEndpointId" ;
            public static string IpAddressCount =  "IpAddressCount" ;
            public static string Arn =  "Arn" ;
            public static string Direction =  "Direction" ;
            public static string HostVPCId =  "HostVPCId" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Route53Resolver::ResolverEndpoint";
            }
        }

        /// <summary>
        /// IpAddresses
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-ipaddresses
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IpAddressRequest
        /// </summary>
        public List<IpAddressRequest> IpAddresses
        {
            get;
            set;
        }

        /// <summary>
        /// Direction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-direction
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Direction
        {
            get;
            set;
        }

        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-securitygroupids
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-route53resolver-resolverendpoint.html#cfn-route53resolver-resolverendpoint-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace ResolverEndpointTypes
    {
        public class IpAddressRequest
        {
            /// <summary>
            /// Ip
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html#cfn-route53resolver-resolverendpoint-ipaddressrequest-ip
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ip
            {
                get;
                set;
            }

            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-route53resolver-resolverendpoint-ipaddressrequest.html#cfn-route53resolver-resolverendpoint-ipaddressrequest-subnetid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId
            {
                get;
                set;
            }
        }
    }
}