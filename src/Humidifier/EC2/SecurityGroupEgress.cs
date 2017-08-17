namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using SecurityGroupEgressPropertyTypes;

    public class SecurityGroupEgress : Humidifier.Resource
    {
        /// <summary>
        /// CidrIp
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-cidrip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrIp
        {
            get;
            set;
        }

        /// <summary>
        /// CidrIpv6
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-cidripv6
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CidrIpv6
        {
            get;
            set;
        }

        /// <summary>
        /// DestinationPrefixListId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-destinationprefixlistid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationPrefixListId
        {
            get;
            set;
        }

        /// <summary>
        /// DestinationSecurityGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-destinationsecuritygroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationSecurityGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// FromPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-fromport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? FromPort
        {
            get;
            set;
        }

        /// <summary>
        /// GroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-groupid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupId
        {
            get;
            set;
        }

        /// <summary>
        /// IpProtocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-ipprotocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IpProtocol
        {
            get;
            set;
        }

        /// <summary>
        /// ToPort
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-security-group-egress.html#cfn-ec2-securitygroupegress-toport
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? ToPort
        {
            get;
            set;
        }
    }

    namespace SecurityGroupEgressPropertyTypes
    {
    }
}