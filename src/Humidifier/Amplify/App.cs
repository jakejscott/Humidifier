namespace Humidifier.Amplify
{
    using System.Collections.Generic;
    using AppTypes;

    public class App : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string AppId =  "AppId" ;
            public static string Arn =  "Arn" ;
            public static string DefaultDomain =  "DefaultDomain" ;
            public static string AppName =  "AppName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Amplify::App";
            }
        }

        /// <summary>
        /// AutoBranchCreationConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-autobranchcreationconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AutoBranchCreationConfig
        /// </summary>
        public AutoBranchCreationConfig AutoBranchCreationConfig
        {
            get;
            set;
        }

        /// <summary>
        /// OauthToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-oauthtoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OauthToken
        {
            get;
            set;
        }

        /// <summary>
        /// Repository
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-repository
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Repository
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-description
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
        /// EnvironmentVariables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-environmentvariables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: EnvironmentVariable
        /// </summary>
        public List<EnvironmentVariable> EnvironmentVariables
        {
            get;
            set;
        }

        /// <summary>
        /// AccessToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-accesstoken
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AccessToken
        {
            get;
            set;
        }

        /// <summary>
        /// BuildSpec
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-buildspec
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BuildSpec
        {
            get;
            set;
        }

        /// <summary>
        /// CustomRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-customrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: CustomRule
        /// </summary>
        public List<CustomRule> CustomRules
        {
            get;
            set;
        }

        /// <summary>
        /// BasicAuthConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-basicauthconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: BasicAuthConfig
        /// </summary>
        public BasicAuthConfig BasicAuthConfig
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-tags
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
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-name
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
        /// IAMServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amplify-app.html#cfn-amplify-app-iamservicerole
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IAMServiceRole
        {
            get;
            set;
        }
    }

    namespace AppTypes
    {
        public class BasicAuthConfig
        {
            /// <summary>
            /// Username
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-username
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Username
            {
                get;
                set;
            }

            /// <summary>
            /// EnableBasicAuth
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-enablebasicauth
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableBasicAuth
            {
                get;
                set;
            }

            /// <summary>
            /// Password
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-basicauthconfig.html#cfn-amplify-app-basicauthconfig-password
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Password
            {
                get;
                set;
            }
        }

        public class EnvironmentVariable
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-environmentvariable.html#cfn-amplify-app-environmentvariable-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-environmentvariable.html#cfn-amplify-app-environmentvariable-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class CustomRule
        {
            /// <summary>
            /// Condition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-condition
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Condition
            {
                get;
                set;
            }

            /// <summary>
            /// Status
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-status
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Status
            {
                get;
                set;
            }

            /// <summary>
            /// Target
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-target
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Target
            {
                get;
                set;
            }

            /// <summary>
            /// Source
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-customrule.html#cfn-amplify-app-customrule-source
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Source
            {
                get;
                set;
            }
        }

        public class AutoBranchCreationConfig
        {
            /// <summary>
            /// EnvironmentVariables
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-environmentvariables
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: EnvironmentVariable
            /// </summary>
            public List<EnvironmentVariable> EnvironmentVariables
            {
                get;
                set;
            }

            /// <summary>
            /// EnableAutoBranchCreation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enableautobranchcreation
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableAutoBranchCreation
            {
                get;
                set;
            }

            /// <summary>
            /// PullRequestEnvironmentName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-pullrequestenvironmentname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PullRequestEnvironmentName
            {
                get;
                set;
            }

            /// <summary>
            /// AutoBranchCreationPatterns
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-autobranchcreationpatterns
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AutoBranchCreationPatterns
            {
                get;
                set;
            }

            /// <summary>
            /// EnablePullRequestPreview
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enablepullrequestpreview
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnablePullRequestPreview
            {
                get;
                set;
            }

            /// <summary>
            /// EnableAutoBuild
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-enableautobuild
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EnableAutoBuild
            {
                get;
                set;
            }

            /// <summary>
            /// BuildSpec
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-buildspec
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BuildSpec
            {
                get;
                set;
            }

            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-stage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stage
            {
                get;
                set;
            }

            /// <summary>
            /// BasicAuthConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-amplify-app-autobranchcreationconfig.html#cfn-amplify-app-autobranchcreationconfig-basicauthconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BasicAuthConfig
            /// </summary>
            public BasicAuthConfig BasicAuthConfig
            {
                get;
                set;
            }
        }
    }
}