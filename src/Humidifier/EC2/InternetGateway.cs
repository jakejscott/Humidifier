namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using InternetGatewayPropertyTypes;

    public class InternetGateway : IResource
    {
        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-internetgateway.html#cfn-ec2-internetgateway-tags
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

    namespace InternetGatewayPropertyTypes
    {
    }
}