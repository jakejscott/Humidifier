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
        /// DeliveryPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-subscription-deliverypolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic DeliveryPolicy
        {
            get;
            set;
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
        /// FilterPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-subscription-filterpolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic FilterPolicy
        {
            get;
            set;
        }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-protocol
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Protocol
        {
            get;
            set;
        }

        /// <summary>
        /// RawMessageDelivery
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-subscription-rawmessagedelivery
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RawMessageDelivery
        {
            get;
            set;
        }

        /// <summary>
        /// Region
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#cfn-sns-subscription-region
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Region
        {
            get;
            set;
        }

        /// <summary>
        /// TopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sns-subscription.html#topicarn
        /// Required: True
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