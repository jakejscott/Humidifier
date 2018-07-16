namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using ModelTypes;

    public class Model : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string ModelName =  "ModelName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::Model";
            }
        }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-executionrolearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// PrimaryContainer
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-primarycontainer
        /// Required: True
        /// UpdateType: Immutable
        /// Type: ContainerDefinition
        /// </summary>
        public ContainerDefinition PrimaryContainer
        {
            get;
            set;
        }

        /// <summary>
        /// ModelName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-modelname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ModelName
        {
            get;
            set;
        }

        /// <summary>
        /// VpcConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-vpcconfig
        /// Required: False
        /// UpdateType: Immutable
        /// Type: VpcConfig
        /// </summary>
        public VpcConfig VpcConfig
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-model.html#cfn-sagemaker-model-tags
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

    namespace ModelTypes
    {
        public class VpcConfig
        {
            /// <summary>
            /// Subnets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html#cfn-sagemaker-model-vpcconfig-subnets
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Subnets
            {
                get;
                set;
            }

            /// <summary>
            /// SecurityGroupIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-vpcconfig.html#cfn-sagemaker-model-vpcconfig-securitygroupids
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic SecurityGroupIds
            {
                get;
                set;
            }
        }

        public class ContainerDefinition
        {
            /// <summary>
            /// ContainerHostname
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-containerhostname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerHostname
            {
                get;
                set;
            }

            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-environment
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Environment
            {
                get;
                set;
            }

            /// <summary>
            /// ModelDataUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-modeldataurl
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelDataUrl
            {
                get;
                set;
            }

            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-model-containerdefinition.html#cfn-sagemaker-model-containerdefinition-image
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image
            {
                get;
                set;
            }
        }
    }
}