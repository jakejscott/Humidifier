namespace Humidifier.ElasticBeanstalk
{
    using System.Collections.Generic;
    using ApplicationTypes;

    public class Application : Humidifier.Resource
    {
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-description
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
        /// ResourceLifecycleConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-resourcelifecycleconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ApplicationResourceLifecycleConfig
        /// </summary>
        public ApplicationResourceLifecycleConfig ResourceLifecycleConfig
        {
            get;
            set;
        }
    }

    namespace ApplicationTypes
    {
        public class ApplicationResourceLifecycleConfig
        {
            /// <summary>
            /// ServiceRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-servicerole
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceRole
            {
                get;
                set;
            }

            /// <summary>
            /// VersionLifecycleConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationresourcelifecycleconfig.html#cfn-elasticbeanstalk-application-applicationresourcelifecycleconfig-versionlifecycleconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApplicationVersionLifecycleConfig
            /// </summary>
            public ApplicationVersionLifecycleConfig VersionLifecycleConfig
            {
                get;
                set;
            }
        }

        public class ApplicationVersionLifecycleConfig
        {
            /// <summary>
            /// MaxAgeRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxagerule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxAgeRule
            /// </summary>
            public MaxAgeRule MaxAgeRule
            {
                get;
                set;
            }

            /// <summary>
            /// MaxCountRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-applicationversionlifecycleconfig.html#cfn-elasticbeanstalk-application-applicationversionlifecycleconfig-maxcountrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MaxCountRule
            /// </summary>
            public MaxCountRule MaxCountRule
            {
                get;
                set;
            }
        }

        public class MaxCountRule
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteSourceFromS3
            {
                get;
                set;
            }

            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }

            /// <summary>
            /// MaxCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxcountrule.html#cfn-elasticbeanstalk-application-maxcountrule-maxcount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCount
            {
                get;
                set;
            }
        }

        public class MaxAgeRule
        {
            /// <summary>
            /// DeleteSourceFromS3
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-deletesourcefroms3
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteSourceFromS3
            {
                get;
                set;
            }

            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Enabled
            {
                get;
                set;
            }

            /// <summary>
            /// MaxAgeInDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticbeanstalk-application-maxagerule.html#cfn-elasticbeanstalk-application-maxagerule-maxageindays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxAgeInDays
            {
                get;
                set;
            }
        }
    }
}