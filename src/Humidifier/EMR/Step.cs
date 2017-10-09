namespace Humidifier.EMR
{
    using System.Collections.Generic;
    using StepPropertyTypes;

    public class Step : Humidifier.Resource
    {
        /// <summary>
        /// ActionOnFailure
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-actiononfailure
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ActionOnFailure
        {
            get;
            set;
        }

        /// <summary>
        /// HadoopJarStep
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-hadoopjarstep
        /// Required: True
        /// UpdateType: Immutable
        /// Type: HadoopJarStepConfig
        /// </summary>
        public HadoopJarStepConfig HadoopJarStep
        {
            get;
            set;
        }

        /// <summary>
        /// JobFlowId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-jobflowid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobFlowId
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-step.html#cfn-elasticmapreduce-step-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace StepPropertyTypes
    {
        public class HadoopJarStepConfig
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-hadoopjarstepconfig.html#cfn-elasticmapreduce-step-hadoopjarstepconfig-args
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Args
            {
                get;
                set;
            }

            /// <summary>
            /// Jar
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-hadoopjarstepconfig.html#cfn-elasticmapreduce-step-hadoopjarstepconfig-jar
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Jar
            {
                get;
                set;
            }

            /// <summary>
            /// MainClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-hadoopjarstepconfig.html#cfn-elasticmapreduce-step-hadoopjarstepconfig-mainclass
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MainClass
            {
                get;
                set;
            }

            /// <summary>
            /// StepProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-hadoopjarstepconfig.html#cfn-elasticmapreduce-step-hadoopjarstepconfig-stepproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: KeyValue
            /// </summary>
            public List<KeyValue> StepProperties
            {
                get;
                set;
            }
        }

        public class KeyValue
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-keyvalue.html#cfn-elasticmapreduce-step-keyvalue-key
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-step-keyvalue.html#cfn-elasticmapreduce-step-keyvalue-value
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }
    }
}