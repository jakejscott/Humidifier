namespace Humidifier.Redshift
{
    using System.Collections.Generic;

    public class ClusterSecurityGroupIngress : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Redshift::ClusterSecurityGroupIngress";
            }
        }

        /// <summary>
        /// CIDRIP
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-cidrip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CIDRIP
        {
            get;
            set;
        }

        /// <summary>
        /// ClusterSecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-clustersecuritygroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterSecurityGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// EC2SecurityGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-ec2securitygroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EC2SecurityGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// EC2SecurityGroupOwnerId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-redshift-clustersecuritygroupingress.html#cfn-redshift-clustersecuritygroupingress-ec2securitygroupownerid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EC2SecurityGroupOwnerId
        {
            get;
            set;
        }
    }
}