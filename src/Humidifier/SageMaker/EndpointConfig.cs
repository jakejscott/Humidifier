namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using EndpointConfigTypes;

    public class EndpointConfig : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string EndpointConfigName =  "EndpointConfigName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::EndpointConfig";
            }
        }

        /// <summary>
        /// ProductionVariants
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-productionvariants
        /// Required: True
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: ProductionVariant
        /// </summary>
        public List<ProductionVariant> ProductionVariants
        {
            get;
            set;
        }

        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// EndpointConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-endpointconfigname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointConfigName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpointconfig.html#cfn-sagemaker-endpointconfig-tags
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

    namespace EndpointConfigTypes
    {
        public class ProductionVariant
        {
            /// <summary>
            /// ModelName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-modelname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ModelName
            {
                get;
                set;
            }

            /// <summary>
            /// VariantName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-variantname
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariantName
            {
                get;
                set;
            }

            /// <summary>
            /// InitialInstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialinstancecount
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InitialInstanceCount
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-instancetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType
            {
                get;
                set;
            }

            /// <summary>
            /// InitialVariantWeight
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpointconfig-productionvariant.html#cfn-sagemaker-endpointconfig-productionvariant-initialvariantweight
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic InitialVariantWeight
            {
                get;
                set;
            }
        }
    }
}