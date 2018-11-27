namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class EIP : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string AllocationId =  "AllocationId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::EIP";
            }
        }

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

        /// <summary>
        /// PublicIpv4Pool
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-eip.html#cfn-ec2-eip-publicipv4pool
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PublicIpv4Pool
        {
            get;
            set;
        }
    }
}