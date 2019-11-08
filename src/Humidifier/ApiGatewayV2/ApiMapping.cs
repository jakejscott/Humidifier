namespace Humidifier.ApiGatewayV2
{
    using System.Collections.Generic;

    public class ApiMapping : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ApiGatewayV2::ApiMapping";
            }
        }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apimapping.html#cfn-apigatewayv2-apimapping-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName
        {
            get;
            set;
        }

        /// <summary>
        /// Stage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apimapping.html#cfn-apigatewayv2-apimapping-stage
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Stage
        {
            get;
            set;
        }

        /// <summary>
        /// ApiMappingKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apimapping.html#cfn-apigatewayv2-apimapping-apimappingkey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApiMappingKey
        {
            get;
            set;
        }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigatewayv2-apimapping.html#cfn-apigatewayv2-apimapping-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApiId
        {
            get;
            set;
        }
    }
}