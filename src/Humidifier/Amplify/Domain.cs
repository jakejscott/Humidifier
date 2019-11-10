namespace Humidifier.Amplify
{
    using System.Collections.Generic;
    using DomainTypes;

    public class Domain : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string DomainName =  "DomainName" ;
            public static string StatusReason =  "StatusReason" ;
            public static string Arn =  "Arn" ;
            public static string DomainStatus =  "DomainStatus" ;
            public static string CertificateRecord =  "CertificateRecord" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Amplify::Domain";
            }
        }

        /// <summary>
        /// SubDomainSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-subdomainsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SubDomainSetting
        /// </summary>
        public List<SubDomainSetting> SubDomainSettings
        {
            get;
            set;
        }

        /// <summary>
        /// AppId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-appid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AppId
        {
            get;
            set;
        }

        /// <summary>
        /// DomainName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-domain.html#cfn-amplify-domain-domainname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainName
        {
            get;
            set;
        }
    }

    namespace DomainTypes
    {
        public class SubDomainSetting
        {
            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html#cfn-amplify-domain-subdomainsetting-prefix
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// BranchName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-domain-subdomainsetting.html#cfn-amplify-domain-subdomainsetting-branchname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BranchName
            {
                get;
                set;
            }
        }
    }
}