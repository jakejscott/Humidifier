namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VPCPropertyTypes;

    public class VPC : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string CidrBlock =  "CidrBlock" ;
            public static string CidrBlockAssociations =  "CidrBlockAssociations" ;
            public static string DefaultNetworkAcl =  "DefaultNetworkAcl" ;
            public static string DefaultSecurityGroup =  "DefaultSecurityGroup" ;
            public static string Ipv6CidrBlocks =  "Ipv6CidrBlocks" ;
        }

        /// <summary>
        /// CidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-cidrblock
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrBlock
        {
            get;
            set;
        }

        /// <summary>
        /// EnableDnsHostnames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsHostnames
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsHostnames
        {
            get;
            set;
        }

        /// <summary>
        /// EnableDnsSupport
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-EnableDnsSupport
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableDnsSupport
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceTenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-instancetenancy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceTenancy
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpc.html#cfn-aws-ec2-vpc-tags
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
    }

    namespace VPCPropertyTypes
    {
    }
}