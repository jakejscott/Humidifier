namespace Humidifier.SQS
{
    using System.Collections.Generic;
    using QueuePropertyTypes;

    public class Queue : Humidifier.Resource
    {
        /// <summary>
        /// ContentBasedDeduplication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-contentbaseddeduplication
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? ContentBasedDeduplication
        {
            get;
            set;
        }

        /// <summary>
        /// DelaySeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-delayseconds
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? DelaySeconds
        {
            get;
            set;
        }

        /// <summary>
        /// FifoQueue
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-fifoqueue
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? FifoQueue
        {
            get;
            set;
        }

        /// <summary>
        /// MaximumMessageSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-maxmesgsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? MaximumMessageSize
        {
            get;
            set;
        }

        /// <summary>
        /// MessageRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-msgretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? MessageRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// QueueName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic QueueName
        {
            get;
            set;
        }

        /// <summary>
        /// ReceiveMessageWaitTimeSeconds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-receivemsgwaittime
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? ReceiveMessageWaitTimeSeconds
        {
            get;
            set;
        }

        /// <summary>
        /// RedrivePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-redrive
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic RedrivePolicy
        {
            get;
            set;
        }

        /// <summary>
        /// VisibilityTimeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sqs-queues.html#aws-sqs-queue-visiblitytimeout
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? VisibilityTimeout
        {
            get;
            set;
        }
    }

    namespace QueuePropertyTypes
    {
    }
}