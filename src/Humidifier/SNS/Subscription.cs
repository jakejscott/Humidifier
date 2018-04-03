namespace Humidifier.SNS
{
    using System.Collections.Generic;

    public class Subscription : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SNS::Subscription";
            }
        }

        /// <summary>
        /// Endpoint
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-endpoint
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Endpoint
        {
            get;
            set;
        }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-protocol
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol
        {
            get;
            set;
        }

        /// <summary>
        /// TopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#topicarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TopicArn
        {
            get;
            set;
        }
    }
}