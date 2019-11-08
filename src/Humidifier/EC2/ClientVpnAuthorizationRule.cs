namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class ClientVpnAuthorizationRule : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::ClientVpnAuthorizationRule";
            }
        }

        /// <summary>
        /// ClientVpnEndpointId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-clientvpnendpointid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientVpnEndpointId
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-description
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
        /// AccessGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-accessgroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// TargetNetworkCidr
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-targetnetworkcidr
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetNetworkCidr
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizeAllGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-clientvpnauthorizationrule.html#cfn-ec2-clientvpnauthorizationrule-authorizeallgroups
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AuthorizeAllGroups
        {
            get;
            set;
        }
    }
}