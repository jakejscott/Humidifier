namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using CertificatePropertyTypes;

    public class Certificate : Humidifier.Resource
    {
        /// <summary>
        /// CertificateSigningRequest
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-certificatesigningrequest
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateSigningRequest
        {
            get;
            set;
        }

        /// <summary>
        /// Status
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-certificate.html#cfn-iot-certificate-status
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Status
        {
            get;
            set;
        }
    }

    namespace CertificatePropertyTypes
    {
    }
}