namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using EndpointTypes;

    public class Endpoint : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string EndpointName =  "EndpointName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::Endpoint";
            }
        }

        /// <summary>
        /// RetainAllVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-retainallvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RetainAllVariantProperties
        {
            get;
            set;
        }

        /// <summary>
        /// EndpointName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-endpointname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointName
        {
            get;
            set;
        }

        /// <summary>
        /// ExcludeRetainedVariantProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-excluderetainedvariantproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: VariantProperty
        /// </summary>
        public List<VariantProperty> ExcludeRetainedVariantProperties
        {
            get;
            set;
        }

        /// <summary>
        /// EndpointConfigName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-endpointconfigname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EndpointConfigName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-endpoint.html#cfn-sagemaker-endpoint-tags
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

    namespace EndpointTypes
    {
        public class VariantProperty
        {
            /// <summary>
            /// VariantPropertyType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-endpoint-variantproperty.html#cfn-sagemaker-endpoint-variantproperty-variantpropertytype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VariantPropertyType
            {
                get;
                set;
            }
        }
    }
}