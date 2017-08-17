namespace Humidifier.SNS
{
    using System.Collections.Generic;
    using TopicPropertyTypes;

    public class Topic : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string TopicName =  "TopicName" ;
        }

        /// <summary>
        /// DisplayName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-displayname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DisplayName
        {
            get;
            set;
        }

        /// <summary>
        /// Subscription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-subscription
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Subscription
        /// </summary>
        public List<Subscription> Subscription
        {
            get;
            set;
        }

        /// <summary>
        /// TopicName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-topic.html#cfn-sns-topic-topicname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TopicName
        {
            get;
            set;
        }
    }

    namespace TopicPropertyTypes
    {
        public class Subscription
        {
            /// <summary>
            /// Endpoint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-subscription.html#cfn-sns-topic-subscription-endpoint
            /// Required: True
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sns-subscription.html#cfn-sns-topic-subscription-protocol
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol
            {
                get;
                set;
            }
        }
    }
}