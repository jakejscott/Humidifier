namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using CloudFrontOriginAccessIdentityTypes;

    public class CloudFrontOriginAccessIdentity : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string S3CanonicalUserId =  "S3CanonicalUserId" ;
        }

        /// <summary>
        /// CloudFrontOriginAccessIdentityConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cloudfront-cloudfrontoriginaccessidentity.html#cfn-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: CloudFrontOriginAccessIdentityConfig
        /// </summary>
        public CloudFrontOriginAccessIdentityConfig CloudFrontOriginAccessIdentityConfig
        {
            get;
            set;
        }
    }

    namespace CloudFrontOriginAccessIdentityTypes
    {
        public class CloudFrontOriginAccessIdentityConfig
        {
            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig.html#cfn-cloudfront-cloudfrontoriginaccessidentity-cloudfrontoriginaccessidentityconfig-comment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment
            {
                get;
                set;
            }
        }
    }
}