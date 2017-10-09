namespace Humidifier.CloudFront
{
    using System.Collections.Generic;
    using DistributionPropertyTypes;

    public class Distribution : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string DomainName =  "DomainName" ;
        }

        /// <summary>
        /// DistributionConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distribution.html#cfn-cloudfront-distribution-distributionconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DistributionConfig
        /// </summary>
        public DistributionConfig DistributionConfig
        {
            get;
            set;
        }
    }

    namespace DistributionPropertyTypes
    {
        public class Cookies
        {
            /// <summary>
            /// Forward
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues-cookies.html#cfn-cloudfront-forwardedvalues-cookies-forward
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Forward
            {
                get;
                set;
            }

            /// <summary>
            /// WhitelistedNames
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues-cookies.html#cfn-cloudfront-forwardedvalues-cookies-whitelistednames
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic WhitelistedNames
            {
                get;
                set;
            }
        }

        public class CustomOriginConfig
        {
            /// <summary>
            /// HTTPPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-customorigin.html#cfn-cloudfront-customorigin-httpport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HTTPPort
            {
                get;
                set;
            }

            /// <summary>
            /// HTTPSPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-customorigin.html#cfn-cloudfront-customorigin-httpsport
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HTTPSPort
            {
                get;
                set;
            }

            /// <summary>
            /// OriginProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-customorigin.html#cfn-cloudfront-customorigin-originprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginProtocolPolicy
            {
                get;
                set;
            }

            /// <summary>
            /// OriginSSLProtocols
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-customorigin.html#cfn-cloudfront-customorigin-originsslprotocols
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic OriginSSLProtocols
            {
                get;
                set;
            }
        }

        public class ForwardedValues
        {
            /// <summary>
            /// Cookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues.html#cfn-cloudfront-forwardedvalues-cookies
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Cookies
            /// </summary>
            public Cookies Cookies
            {
                get;
                set;
            }

            /// <summary>
            /// Headers
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues.html#cfn-cloudfront-forwardedvalues-headers
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Headers
            {
                get;
                set;
            }

            /// <summary>
            /// QueryString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues.html#cfn-cloudfront-forwardedvalues-querystring
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic QueryString
            {
                get;
                set;
            }

            /// <summary>
            /// QueryStringCacheKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-forwardedvalues.html#cfn-cloudfront-forwardedvalues-querystringcachekeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic QueryStringCacheKeys
            {
                get;
                set;
            }
        }

        public class CacheBehavior
        {
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-allowedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedMethods
            {
                get;
                set;
            }

            /// <summary>
            /// CachedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-cachedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CachedMethods
            {
                get;
                set;
            }

            /// <summary>
            /// Compress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-compress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Compress
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic DefaultTTL
            {
                get;
                set;
            }

            /// <summary>
            /// ForwardedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-forwardedvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ForwardedValues
            /// </summary>
            public ForwardedValues ForwardedValues
            {
                get;
                set;
            }

            /// <summary>
            /// MaxTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-maxttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic MaxTTL
            {
                get;
                set;
            }

            /// <summary>
            /// MinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-minttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic MinTTL
            {
                get;
                set;
            }

            /// <summary>
            /// PathPattern
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-pathpattern
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PathPattern
            {
                get;
                set;
            }

            /// <summary>
            /// SmoothStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-smoothstreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SmoothStreaming
            {
                get;
                set;
            }

            /// <summary>
            /// TargetOriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-targetoriginid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetOriginId
            {
                get;
                set;
            }

            /// <summary>
            /// TrustedSigners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-trustedsigners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TrustedSigners
            {
                get;
                set;
            }

            /// <summary>
            /// ViewerProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-cachebehavior.html#cfn-cloudfront-cachebehavior-viewerprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ViewerProtocolPolicy
            {
                get;
                set;
            }
        }

        public class DefaultCacheBehavior
        {
            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-allowedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AllowedMethods
            {
                get;
                set;
            }

            /// <summary>
            /// CachedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-cachedmethods
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CachedMethods
            {
                get;
                set;
            }

            /// <summary>
            /// Compress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-compress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Compress
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-defaultttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic DefaultTTL
            {
                get;
                set;
            }

            /// <summary>
            /// ForwardedValues
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-forwardedvalues
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ForwardedValues
            /// </summary>
            public ForwardedValues ForwardedValues
            {
                get;
                set;
            }

            /// <summary>
            /// MaxTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-maxttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic MaxTTL
            {
                get;
                set;
            }

            /// <summary>
            /// MinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-minttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic MinTTL
            {
                get;
                set;
            }

            /// <summary>
            /// SmoothStreaming
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-smoothstreaming
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic SmoothStreaming
            {
                get;
                set;
            }

            /// <summary>
            /// TargetOriginId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-targetoriginid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetOriginId
            {
                get;
                set;
            }

            /// <summary>
            /// TrustedSigners
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-trustedsigners
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic TrustedSigners
            {
                get;
                set;
            }

            /// <summary>
            /// ViewerProtocolPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-defaultcachebehavior.html#cfn-cloudfront-defaultcachebehavior-viewerprotocolpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ViewerProtocolPolicy
            {
                get;
                set;
            }
        }

        public class Restrictions
        {
            /// <summary>
            /// GeoRestriction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-restrictions.html#cfn-cloudfront-distributionconfig-restrictions-georestriction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: GeoRestriction
            /// </summary>
            public GeoRestriction GeoRestriction
            {
                get;
                set;
            }
        }

        public class Origin
        {
            /// <summary>
            /// CustomOriginConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-customorigin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CustomOriginConfig
            /// </summary>
            public CustomOriginConfig CustomOriginConfig
            {
                get;
                set;
            }

            /// <summary>
            /// DomainName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-domainname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DomainName
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-id
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// OriginCustomHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-origincustomheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: OriginCustomHeader
            /// </summary>
            public List<OriginCustomHeader> OriginCustomHeaders
            {
                get;
                set;
            }

            /// <summary>
            /// OriginPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-originpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginPath
            {
                get;
                set;
            }

            /// <summary>
            /// S3OriginConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin.html#cfn-cloudfront-origin-s3origin
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3OriginConfig
            /// </summary>
            public S3OriginConfig S3OriginConfig
            {
                get;
                set;
            }
        }

        public class GeoRestriction
        {
            /// <summary>
            /// Locations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-restrictions-georestriction.html#cfn-cloudfront-distributionconfig-restrictions-georestriction-locations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Locations
            {
                get;
                set;
            }

            /// <summary>
            /// RestrictionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-restrictions-georestriction.html#cfn-cloudfront-distributionconfig-restrictions-georestriction-restrictiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RestrictionType
            {
                get;
                set;
            }
        }

        public class ViewerCertificate
        {
            /// <summary>
            /// AcmCertificateArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-viewercertificate.html#cfn-cloudfront-distributionconfig-viewercertificate-acmcertificatearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AcmCertificateArn
            {
                get;
                set;
            }

            /// <summary>
            /// CloudFrontDefaultCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-viewercertificate.html#cfn-cloudfront-distributionconfig-viewercertificate-cloudfrontdefaultcertificate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CloudFrontDefaultCertificate
            {
                get;
                set;
            }

            /// <summary>
            /// IamCertificateId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-viewercertificate.html#cfn-cloudfront-distributionconfig-viewercertificate-iamcertificateid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamCertificateId
            {
                get;
                set;
            }

            /// <summary>
            /// MinimumProtocolVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-viewercertificate.html#cfn-cloudfront-distributionconfig-viewercertificate-sslsupportmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MinimumProtocolVersion
            {
                get;
                set;
            }

            /// <summary>
            /// SslSupportMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-viewercertificate.html#cfn-cloudfront-distributionconfig-viewercertificate-minimumprotocolversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SslSupportMethod
            {
                get;
                set;
            }
        }

        public class S3OriginConfig
        {
            /// <summary>
            /// OriginAccessIdentity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-s3origin.html#cfn-cloudfront-s3origin-originaccessidentity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OriginAccessIdentity
            {
                get;
                set;
            }
        }

        public class CustomErrorResponse
        {
            /// <summary>
            /// ErrorCachingMinTTL
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-customerrorresponse.html#cfn-cloudfront-distributionconfig-customerrorresponse-errorcachingminttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Long
            /// </summary>
            public dynamic ErrorCachingMinTTL
            {
                get;
                set;
            }

            /// <summary>
            /// ErrorCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-customerrorresponse.html#cfn-cloudfront-distributionconfig-customerrorresponse-errorcode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ErrorCode
            {
                get;
                set;
            }

            /// <summary>
            /// ResponseCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-customerrorresponse.html#cfn-cloudfront-distributionconfig-customerrorresponse-responsecode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ResponseCode
            {
                get;
                set;
            }

            /// <summary>
            /// ResponsePagePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig-customerrorresponse.html#cfn-cloudfront-distributionconfig-customerrorresponse-responsepagepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResponsePagePath
            {
                get;
                set;
            }
        }

        public class DistributionConfig
        {
            /// <summary>
            /// Aliases
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-aliases
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Aliases
            {
                get;
                set;
            }

            /// <summary>
            /// CacheBehaviors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-cachebehaviors
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CacheBehavior
            /// </summary>
            public List<CacheBehavior> CacheBehaviors
            {
                get;
                set;
            }

            /// <summary>
            /// Comment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-comment
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Comment
            {
                get;
                set;
            }

            /// <summary>
            /// CustomErrorResponses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-customerrorresponses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CustomErrorResponse
            /// </summary>
            public List<CustomErrorResponse> CustomErrorResponses
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultCacheBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-defaultcachebehavior
            /// Required: True
            /// UpdateType: Mutable
            /// Type: DefaultCacheBehavior
            /// </summary>
            public DefaultCacheBehavior DefaultCacheBehavior
            {
                get;
                set;
            }

            /// <summary>
            /// DefaultRootObject
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-defaultrootobject
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DefaultRootObject
            {
                get;
                set;
            }

            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-enabled
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }

            /// <summary>
            /// HttpVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-httpversion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpVersion
            {
                get;
                set;
            }

            /// <summary>
            /// Logging
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-logging
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Logging
            /// </summary>
            public Logging Logging
            {
                get;
                set;
            }

            /// <summary>
            /// Origins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-origins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Origin
            /// </summary>
            public List<Origin> Origins
            {
                get;
                set;
            }

            /// <summary>
            /// PriceClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-priceclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PriceClass
            {
                get;
                set;
            }

            /// <summary>
            /// Restrictions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-restrictions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Restrictions
            /// </summary>
            public Restrictions Restrictions
            {
                get;
                set;
            }

            /// <summary>
            /// ViewerCertificate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-viewercertificate
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ViewerCertificate
            /// </summary>
            public ViewerCertificate ViewerCertificate
            {
                get;
                set;
            }

            /// <summary>
            /// WebACLId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-distributionconfig.html#cfn-cloudfront-distributionconfig-webaclid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic WebACLId
            {
                get;
                set;
            }
        }

        public class Logging
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-logging.html#cfn-cloudfront-logging-bucket
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Bucket
            {
                get;
                set;
            }

            /// <summary>
            /// IncludeCookies
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-logging.html#cfn-cloudfront-logging-includecookies
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic IncludeCookies
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-logging.html#cfn-cloudfront-logging-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }
        }

        public class OriginCustomHeader
        {
            /// <summary>
            /// HeaderName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin-origincustomheader.html#cfn-cloudfront-origin-origincustomheader-headername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderName
            {
                get;
                set;
            }

            /// <summary>
            /// HeaderValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudfront-origin-origincustomheader.html#cfn-cloudfront-origin-origincustomheader-headervalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HeaderValue
            {
                get;
                set;
            }
        }
    }
}