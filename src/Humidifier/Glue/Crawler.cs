namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using CrawlerTypes;

    public class Crawler : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Glue::Crawler";
            }
        }

        /// <summary>
        /// Role
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-role
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
        /// Classifiers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-classifiers
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Classifiers
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// SchemaChangePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-schemachangepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SchemaChangePolicy
        /// </summary>
        public SchemaChangePolicy SchemaChangePolicy
        {
            get;
            set;
        }

        /// <summary>
        /// Configuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-configuration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Configuration
        {
            get;
            set;
        }

        /// <summary>
        /// Schedule
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-schedule
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Schedule
        /// </summary>
        public Schedule Schedule
        {
            get;
            set;
        }

        /// <summary>
        /// DatabaseName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-databasename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DatabaseName
        {
            get;
            set;
        }

        /// <summary>
        /// Targets
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-targets
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Targets
        /// </summary>
        public Targets Targets
        {
            get;
            set;
        }

        /// <summary>
        /// CrawlerSecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-crawlersecurityconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CrawlerSecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// TablePrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-tableprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TablePrefix
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-crawler.html#cfn-glue-crawler-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace CrawlerTypes
    {
        public class Targets
        {
            /// <summary>
            /// S3Targets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-s3targets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: S3Target
            /// </summary>
            public List<S3Target> S3Targets
            {
                get;
                set;
            }

            /// <summary>
            /// CatalogTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-catalogtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CatalogTarget
            /// </summary>
            public List<CatalogTarget> CatalogTargets
            {
                get;
                set;
            }

            /// <summary>
            /// JdbcTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-jdbctargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: JdbcTarget
            /// </summary>
            public List<JdbcTarget> JdbcTargets
            {
                get;
                set;
            }

            /// <summary>
            /// DynamoDBTargets
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-targets.html#cfn-glue-crawler-targets-dynamodbtargets
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: DynamoDBTarget
            /// </summary>
            public List<DynamoDBTarget> DynamoDBTargets
            {
                get;
                set;
            }
        }

        public class CatalogTarget
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName
            {
                get;
                set;
            }

            /// <summary>
            /// Tables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-catalogtarget.html#cfn-glue-crawler-catalogtarget-tables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Tables
            {
                get;
                set;
            }
        }

        public class JdbcTarget
        {
            /// <summary>
            /// ConnectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-connectionname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectionName
            {
                get;
                set;
            }

            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path
            {
                get;
                set;
            }

            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-jdbctarget.html#cfn-glue-crawler-jdbctarget-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclusions
            {
                get;
                set;
            }
        }

        public class Schedule
        {
            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schedule.html#cfn-glue-crawler-schedule-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression
            {
                get;
                set;
            }
        }

        public class DynamoDBTarget
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-dynamodbtarget.html#cfn-glue-crawler-dynamodbtarget-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path
            {
                get;
                set;
            }
        }

        public class SchemaChangePolicy
        {
            /// <summary>
            /// UpdateBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html#cfn-glue-crawler-schemachangepolicy-updatebehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UpdateBehavior
            {
                get;
                set;
            }

            /// <summary>
            /// DeleteBehavior
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-schemachangepolicy.html#cfn-glue-crawler-schemachangepolicy-deletebehavior
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeleteBehavior
            {
                get;
                set;
            }
        }

        public class S3Target
        {
            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-path
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path
            {
                get;
                set;
            }

            /// <summary>
            /// Exclusions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-crawler-s3target.html#cfn-glue-crawler-s3target-exclusions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Exclusions
            {
                get;
                set;
            }
        }
    }
}