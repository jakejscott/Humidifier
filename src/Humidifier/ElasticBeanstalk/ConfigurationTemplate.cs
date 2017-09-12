namespace Humidifier.ElasticBeanstalk
{
    using System.Collections.Generic;
    using ConfigurationTemplatePropertyTypes;

    public class ConfigurationTemplate : Humidifier.Resource
    {
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-applicationname
        /// Required: True
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-description
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
        /// EnvironmentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-environmentid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EnvironmentId
        {
            get;
            set;
        }

        /// <summary>
        /// OptionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-optionsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ConfigurationOptionSetting
        /// </summary>
        public List<ConfigurationOptionSetting> OptionSettings
        {
            get;
            set;
        }

        /// <summary>
        /// SolutionStackName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-solutionstackname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SolutionStackName
        {
            get;
            set;
        }

        /// <summary>
        /// SourceConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-beanstalk-configurationtemplate.html#cfn-elasticbeanstalk-configurationtemplate-sourceconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: SourceConfiguration
        /// </summary>
        public SourceConfiguration SourceConfiguration
        {
            get;
            set;
        }
    }

    namespace ConfigurationTemplatePropertyTypes
    {
        public class SourceConfiguration
        {
            /// <summary>
            /// ApplicationName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-configurationtemplate-sourceconfiguration.html#cfn-beanstalk-configurationtemplate-sourceconfiguration-applicationname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApplicationName
            {
                get;
                set;
            }

            /// <summary>
            /// TemplateName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-configurationtemplate-sourceconfiguration.html#cfn-beanstalk-configurationtemplate-sourceconfiguration-templatename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TemplateName
            {
                get;
                set;
            }
        }

        public class ConfigurationOptionSetting
        {
            /// <summary>
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-option-settings.html#cfn-beanstalk-optionsettings-namespace
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace
            {
                get;
                set;
            }

            /// <summary>
            /// OptionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-option-settings.html#cfn-beanstalk-optionsettings-optionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic OptionName
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk-option-settings.html#cfn-beanstalk-optionsettings-value
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