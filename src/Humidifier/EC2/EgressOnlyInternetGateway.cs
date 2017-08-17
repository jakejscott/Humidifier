namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using EgressOnlyInternetGatewayPropertyTypes;

    public class EgressOnlyInternetGateway : IResource
    {
        /// <summary>
        /// VpcId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-egressonlyinternetgateway.html#cfn-ec2-egressonlyinternetgateway-vpcid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VpcId
        {
            get;
            set;
        }
    }

    namespace EgressOnlyInternetGatewayPropertyTypes
    {
    }
}