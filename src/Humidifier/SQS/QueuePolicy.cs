namespace Humidifier.SQS
{
    using System.Collections.Generic;

    public class QueuePolicy : Humidifier.Resource
    {
        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html#cfn-sqs-queuepolicy-policydoc
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic PolicyDocument
        {
            get;
            set;
        }

        /// <summary>
        /// Queues
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-policy.html#cfn-sqs-queuepolicy-queues
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Queues
        {
            get;
            set;
        }
    }
}