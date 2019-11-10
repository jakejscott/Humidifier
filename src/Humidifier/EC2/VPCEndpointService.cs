namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class VPCEndpointService : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::VPCEndpointService";
            }
        }

        /// <summary>
        /// NetworkLoadBalancerArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-networkloadbalancerarns
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic NetworkLoadBalancerArns
        {
            get;
            set;
        }

        /// <summary>
        /// AcceptanceRequired
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-vpcendpointservice.html#cfn-ec2-vpcendpointservice-acceptancerequired
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AcceptanceRequired
        {
            get;
            set;
        }
    }
}