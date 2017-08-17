namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using EIPPropertyTypes;

    public class EIP : Humidifier.Resource
    {
        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-domain
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Domain
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-instanceid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceId
        {
            get;
            set;
        }
    }

    namespace EIPPropertyTypes
    {
    }
}