namespace Humidifier.S3
{
    using System.Collections.Generic;
    using BucketPropertyTypes;

    public class Bucket : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string DomainName =  "DomainName" ;
            public static string DualStackDomainName =  "DualStackDomainName" ;
            public static string WebsiteURL =  "WebsiteURL" ;
        }

        /// <summary>
        /// AccelerateConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-accelerateconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccelerateConfiguration
        /// </summary>
        public AccelerateConfiguration AccelerateConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// AccessControl
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-accesscontrol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessControl
        {
            get;
            set;
        }

        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketName
        {
            get;
            set;
        }

        /// <summary>
        /// CorsConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-crossoriginconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CorsConfiguration
        /// </summary>
        public CorsConfiguration CorsConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// LifecycleConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-lifecycleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecycleConfiguration
        /// </summary>
        public LifecycleConfiguration LifecycleConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// LoggingConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-loggingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LoggingConfiguration
        /// </summary>
        public LoggingConfiguration LoggingConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// MetricsConfigurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-metricsconfigurations
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MetricsConfiguration
        /// </summary>
        public List<MetricsConfiguration> MetricsConfigurations
        {
            get;
            set;
        }

        /// <summary>
        /// NotificationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-notification
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationConfiguration
        /// </summary>
        public NotificationConfiguration NotificationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// ReplicationConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-replicationconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ReplicationConfiguration
        /// </summary>
        public ReplicationConfiguration ReplicationConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-tags
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

        /// <summary>
        /// VersioningConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-versioning
        /// Required: False
        /// UpdateType: Mutable
        /// Type: VersioningConfiguration
        /// </summary>
        public VersioningConfiguration VersioningConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// WebsiteConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket.html#cfn-s3-bucket-websiteconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WebsiteConfiguration
        /// </summary>
        public WebsiteConfiguration WebsiteConfiguration
        {
            get;
            set;
        }
    }

    namespace BucketPropertyTypes
    {
        public class NotificationFilter
        {
            /// <summary>
            /// S3Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter.html#cfn-s3-bucket-notificationconfiguraiton-config-filter-s3key
            /// Required: True
            /// UpdateType: Mutable
            /// Type: S3KeyFilter
            /// </summary>
            public S3KeyFilter S3Key
            {
                get;
                set;
            }
        }

        public class RoutingRuleCondition
        {
            /// <summary>
            /// HttpErrorCodeReturnedEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-routingrulecondition.html#cfn-s3-websiteconfiguration-routingrules-routingrulecondition-httperrorcodereturnedequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpErrorCodeReturnedEquals
            {
                get;
                set;
            }

            /// <summary>
            /// KeyPrefixEquals
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-routingrulecondition.html#cfn-s3-websiteconfiguration-routingrules-routingrulecondition-keyprefixequals
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyPrefixEquals
            {
                get;
                set;
            }
        }

        public class LifecycleConfiguration
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig.html#cfn-s3-bucket-lifecycleconfig-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Rule> Rules
            {
                get;
                set;
            }
        }

        public class LambdaConfiguration
        {
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-lambdaconfig.html#cfn-s3-bucket-notificationconfig-lambdaconfig-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event
            {
                get;
                set;
            }

            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-lambdaconfig.html#cfn-s3-bucket-notificationconfig-lambdaconfig-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter
            {
                get;
                set;
            }

            /// <summary>
            /// Function
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-lambdaconfig.html#cfn-s3-bucket-notificationconfig-lambdaconfig-function
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Function
            {
                get;
                set;
            }
        }

        public class ReplicationRule
        {
            /// <summary>
            /// Destination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-destination
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ReplicationDestination
            /// </summary>
            public ReplicationDestination Destination
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-prefix
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
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules.html#cfn-s3-bucket-replicationconfiguration-rules-status
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

        public class CorsRule
        {
            /// <summary>
            /// AllowedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-allowedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public List<dynamic> AllowedHeaders
            {
                get;
                set;
            }

            /// <summary>
            /// AllowedMethods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-allowedmethods
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public List<dynamic> AllowedMethods
            {
                get;
                set;
            }

            /// <summary>
            /// AllowedOrigins
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-allowedorigins
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public List<dynamic> AllowedOrigins
            {
                get;
                set;
            }

            /// <summary>
            /// ExposedHeaders
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-exposedheaders
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public List<dynamic> ExposedHeaders
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// MaxAge
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors-corsrule.html#cfn-s3-bucket-cors-corsrule-maxage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAge
            {
                get;
                set;
            }
        }

        public class LoggingConfiguration
        {
            /// <summary>
            /// DestinationBucketName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfig.html#cfn-s3-bucket-loggingconfig-destinationbucketname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationBucketName
            {
                get;
                set;
            }

            /// <summary>
            /// LogFilePrefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-loggingconfig.html#cfn-s3-bucket-loggingconfig-logfileprefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LogFilePrefix
            {
                get;
                set;
            }
        }

        public class RoutingRule
        {
            /// <summary>
            /// RedirectRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html#cfn-s3-websiteconfiguration-routingrules-redirectrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: RedirectRule
            /// </summary>
            public RedirectRule RedirectRule
            {
                get;
                set;
            }

            /// <summary>
            /// RoutingRuleCondition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules.html#cfn-s3-websiteconfiguration-routingrules-routingrulecondition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RoutingRuleCondition
            /// </summary>
            public RoutingRuleCondition RoutingRuleCondition
            {
                get;
                set;
            }
        }

        public class VersioningConfiguration
        {
            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-versioningconfig.html#cfn-s3-bucket-versioningconfig-status
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

        public class NotificationConfiguration
        {
            /// <summary>
            /// LambdaConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-lambdaconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: LambdaConfiguration
            /// </summary>
            public List<LambdaConfiguration> LambdaConfigurations
            {
                get;
                set;
            }

            /// <summary>
            /// QueueConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-queueconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: QueueConfiguration
            /// </summary>
            public List<QueueConfiguration> QueueConfigurations
            {
                get;
                set;
            }

            /// <summary>
            /// TopicConfigurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig.html#cfn-s3-bucket-notificationconfig-topicconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TopicConfiguration
            /// </summary>
            public List<TopicConfiguration> TopicConfigurations
            {
                get;
                set;
            }
        }

        public class RedirectRule
        {
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-hostname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostName
            {
                get;
                set;
            }

            /// <summary>
            /// HttpRedirectCode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-httpredirectcode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpRedirectCode
            {
                get;
                set;
            }

            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol
            {
                get;
                set;
            }

            /// <summary>
            /// ReplaceKeyPrefixWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-replacekeyprefixwith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplaceKeyPrefixWith
            {
                get;
                set;
            }

            /// <summary>
            /// ReplaceKeyWith
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-routingrules-redirectrule.html#cfn-s3-websiteconfiguration-redirectrule-replacekeywith
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ReplaceKeyWith
            {
                get;
                set;
            }
        }

        public class RedirectAllRequestsTo
        {
            /// <summary>
            /// HostName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-redirectallrequeststo.html#cfn-s3-websiteconfiguration-redirectallrequeststo-hostname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostName
            {
                get;
                set;
            }

            /// <summary>
            /// Protocol
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration-redirectallrequeststo.html#cfn-s3-websiteconfiguration-redirectallrequeststo-protocol
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Protocol
            {
                get;
                set;
            }
        }

        public class S3KeyFilter
        {
            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key.html#cfn-s3-bucket-notificationconfiguraiton-config-filter-s3key-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: FilterRule
            /// </summary>
            public List<FilterRule> Rules
            {
                get;
                set;
            }
        }

        public class WebsiteConfiguration
        {
            /// <summary>
            /// ErrorDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-errordocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ErrorDocument
            {
                get;
                set;
            }

            /// <summary>
            /// IndexDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-indexdocument
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IndexDocument
            {
                get;
                set;
            }

            /// <summary>
            /// RedirectAllRequestsTo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-redirectallrequeststo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RedirectAllRequestsTo
            /// </summary>
            public RedirectAllRequestsTo RedirectAllRequestsTo
            {
                get;
                set;
            }

            /// <summary>
            /// RoutingRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-websiteconfiguration.html#cfn-s3-websiteconfiguration-routingrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: RoutingRule
            /// </summary>
            public List<RoutingRule> RoutingRules
            {
                get;
                set;
            }
        }

        public class ReplicationConfiguration
        {
            /// <summary>
            /// Role
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-role
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Role
            {
                get;
                set;
            }

            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration.html#cfn-s3-bucket-replicationconfiguration-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ReplicationRule
            /// </summary>
            public List<ReplicationRule> Rules
            {
                get;
                set;
            }
        }

        public class Rule
        {
            /// <summary>
            /// AbortIncompleteMultipartUpload
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-rule-abortincompletemultipartupload
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AbortIncompleteMultipartUpload
            /// </summary>
            public AbortIncompleteMultipartUpload AbortIncompleteMultipartUpload
            {
                get;
                set;
            }

            /// <summary>
            /// ExpirationDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-expirationdate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Timestamp
            /// </summary>
            public dynamic ExpirationDate
            {
                get;
                set;
            }

            /// <summary>
            /// ExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-expirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ExpirationInDays
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-id
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }

            /// <summary>
            /// NoncurrentVersionExpirationInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-noncurrentversionexpirationindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NoncurrentVersionExpirationInDays
            {
                get;
                set;
            }

            /// <summary>
            /// NoncurrentVersionTransition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NoncurrentVersionTransition
            /// </summary>
            public NoncurrentVersionTransition NoncurrentVersionTransition
            {
                get;
                set;
            }

            /// <summary>
            /// NoncurrentVersionTransitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-noncurrentversiontransitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NoncurrentVersionTransition
            /// </summary>
            public List<NoncurrentVersionTransition> NoncurrentVersionTransitions
            {
                get;
                set;
            }

            /// <summary>
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-status
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status
            {
                get;
                set;
            }

            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-rule-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters
            {
                get;
                set;
            }

            /// <summary>
            /// Transition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-transition
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Transition
            /// </summary>
            public Transition Transition
            {
                get;
                set;
            }

            /// <summary>
            /// Transitions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule.html#cfn-s3-bucket-lifecycleconfig-rule-transitions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Transition
            /// </summary>
            public List<Transition> Transitions
            {
                get;
                set;
            }
        }

        public class QueueConfiguration
        {
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-queueconfig.html#cfn-s3-bucket-notificationconfig-queueconfig-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event
            {
                get;
                set;
            }

            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-queueconfig.html#cfn-s3-bucket-notificationconfig-queueconfig-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter
            {
                get;
                set;
            }

            /// <summary>
            /// Queue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-queueconfig.html#cfn-s3-bucket-notificationconfig-queueconfig-queue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Queue
            {
                get;
                set;
            }
        }

        public class TopicConfiguration
        {
            /// <summary>
            /// Event
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-topicconfig.html#cfn-s3-bucket-notificationconfig-topicconfig-event
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Event
            {
                get;
                set;
            }

            /// <summary>
            /// Filter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-topicconfig.html#cfn-s3-bucket-notificationconfig-topicconfig-filter
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NotificationFilter
            /// </summary>
            public NotificationFilter Filter
            {
                get;
                set;
            }

            /// <summary>
            /// Topic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfig-topicconfig.html#cfn-s3-bucket-notificationconfig-topicconfig-topic
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Topic
            {
                get;
                set;
            }
        }

        public class MetricsConfiguration
        {
            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-id
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
            /// Prefix
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-prefix
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Prefix
            {
                get;
                set;
            }

            /// <summary>
            /// TagFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-metricsconfiguration.html#cfn-s3-bucket-metricsconfiguration-tagfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: TagFilter
            /// </summary>
            public List<TagFilter> TagFilters
            {
                get;
                set;
            }
        }

        public class TagFilter
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-tagfilter.html#cfn-s3-bucket-tagfilter-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }

        public class Transition
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-transition.html#cfn-s3-bucket-lifecycleconfig-rule-transition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass
            {
                get;
                set;
            }

            /// <summary>
            /// TransitionDate
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-transition.html#cfn-s3-bucket-lifecycleconfig-rule-transition-transitiondate
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Timestamp
            /// </summary>
            public dynamic TransitionDate
            {
                get;
                set;
            }

            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-transition.html#cfn-s3-bucket-lifecycleconfig-rule-transition-transitionindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransitionInDays
            {
                get;
                set;
            }
        }

        public class CorsConfiguration
        {
            /// <summary>
            /// CorsRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-cors.html#cfn-s3-bucket-cors-corsrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CorsRule
            /// </summary>
            public List<CorsRule> CorsRules
            {
                get;
                set;
            }
        }

        public class ReplicationDestination
        {
            /// <summary>
            /// Bucket
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules-destination.html#cfn-s3-bucket-replicationconfiguration-rules-destination-bucket
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
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-replicationconfiguration-rules-destination.html#cfn-s3-bucket-replicationconfiguration-rules-destination-storageclass
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass
            {
                get;
                set;
            }
        }

        public class AccelerateConfiguration
        {
            /// <summary>
            /// AccelerationStatus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-accelerateconfiguration.html#cfn-s3-bucket-accelerateconfiguration-accelerationstatus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccelerationStatus
            {
                get;
                set;
            }
        }

        public class NoncurrentVersionTransition
        {
            /// <summary>
            /// StorageClass
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition.html#cfn-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition-storageclass
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic StorageClass
            {
                get;
                set;
            }

            /// <summary>
            /// TransitionInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition.html#cfn-s3-bucket-lifecycleconfig-rule-noncurrentversiontransition-transitionindays
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TransitionInDays
            {
                get;
                set;
            }
        }

        public class AbortIncompleteMultipartUpload
        {
            /// <summary>
            /// DaysAfterInitiation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-abortincompletemultipartupload.html#cfn-s3-bucket-abortincompletemultipartupload-daysafterinitiation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic DaysAfterInitiation
            {
                get;
                set;
            }
        }

        public class FilterRule
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key-rules.html#cfn-s3-bucket-notificationconfiguraiton-config-filter-s3key-rules-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-notificationconfiguration-config-filter-s3key-rules.html#cfn-s3-bucket-notificationconfiguraiton-config-filter-s3key-rules-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }
    }
}