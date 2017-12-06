namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using DomainNameTypes;

    public class DomainName : Humidifier.Resource
    {
        /// <summary>
        /// CertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-certificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateArn
        {
            get;
            set;
        }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName_
        {
            get;
            set;
        }

        /// <summary>
        /// EndpointConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-endpointconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: EndpointConfiguration
        /// </summary>
        public EndpointConfiguration EndpointConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// RegionalCertificateArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-domainname.html#cfn-apigateway-domainname-regionalcertificatearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RegionalCertificateArn
        {
            get;
            set;
        }
    }

    namespace DomainNameTypes
    {
        public class EndpointConfiguration
        {
            /// <summary>
            /// Types
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-domainname-endpointconfiguration.html#cfn-apigateway-domainname-endpointconfiguration-types
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Types
            {
                get;
                set;
            }
        }
    }
}