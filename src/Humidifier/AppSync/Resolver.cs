namespace Humidifier.AppSync
{
    using System.Collections.Generic;
    using ResolverTypes;

    public class Resolver : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string TypeName =  "TypeName" ;
            public static string ResolverArn =  "ResolverArn" ;
            public static string FieldName =  "FieldName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppSync::Resolver";
            }
        }

        /// <summary>
        /// ResponseMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResponseMappingTemplateS3Location
        {
            get;
            set;
        }

        /// <summary>
        /// TypeName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-typename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TypeName
        {
            get;
            set;
        }

        /// <summary>
        /// PipelineConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-pipelineconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PipelineConfig
        /// </summary>
        public PipelineConfig PipelineConfig
        {
            get;
            set;
        }

        /// <summary>
        /// DataSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-datasourcename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DataSourceName
        {
            get;
            set;
        }

        /// <summary>
        /// RequestMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RequestMappingTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// ResponseMappingTemplate
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-responsemappingtemplate
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResponseMappingTemplate
        {
            get;
            set;
        }

        /// <summary>
        /// Kind
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-kind
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Kind
        {
            get;
            set;
        }

        /// <summary>
        /// RequestMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-requestmappingtemplates3location
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RequestMappingTemplateS3Location
        {
            get;
            set;
        }

        /// <summary>
        /// ApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-apiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApiId
        {
            get;
            set;
        }

        /// <summary>
        /// FieldName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-fieldname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FieldName
        {
            get;
            set;
        }
    }

    namespace ResolverTypes
    {
        public class PipelineConfig
        {
            /// <summary>
            /// Functions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-pipelineconfig.html#cfn-appsync-resolver-pipelineconfig-functions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Functions
            {
                get;
                set;
            }
        }
    }
}