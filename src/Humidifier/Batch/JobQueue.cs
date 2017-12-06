namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using JobQueueTypes;

    public class JobQueue : Humidifier.Resource
    {
        /// <summary>
        /// ComputeEnvironmentOrder
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-computeenvironmentorder
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ComputeEnvironmentOrder
        /// </summary>
        public List<ComputeEnvironmentOrder> ComputeEnvironmentOrder
        {
            get;
            set;
        }

        /// <summary>
        /// Priority
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-priority
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Priority
        {
            get;
            set;
        }

        /// <summary>
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State
        {
            get;
            set;
        }

        /// <summary>
        /// JobQueueName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobqueue.html#cfn-batch-jobqueue-jobqueuename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobQueueName
        {
            get;
            set;
        }
    }

    namespace JobQueueTypes
    {
        public class ComputeEnvironmentOrder
        {
            /// <summary>
            /// ComputeEnvironment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html#cfn-batch-jobqueue-computeenvironmentorder-computeenvironment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeEnvironment
            {
                get;
                set;
            }

            /// <summary>
            /// Order
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobqueue-computeenvironmentorder.html#cfn-batch-jobqueue-computeenvironmentorder-order
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Order
            {
                get;
                set;
            }
        }
    }
}