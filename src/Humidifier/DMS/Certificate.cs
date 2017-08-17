namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using CertificatePropertyTypes;

    public class Certificate : IResource
    {
        /// <summary>
        /// CertificateIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificateidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// CertificatePem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificatepem
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificatePem
        {
            get;
            set;
        }

        /// <summary>
        /// CertificateWallet
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-certificate.html#cfn-dms-certificate-certificatewallet
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CertificateWallet
        {
            get;
            set;
        }
    }

    namespace CertificatePropertyTypes
    {
    }
}