namespace Humidifier.SageMaker
{
    using System.Collections.Generic;

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
}