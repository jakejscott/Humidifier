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
        /// CachingConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-cachingconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CachingConfig
        /// </summary>
        public CachingConfig CachingConfig
        {
            get;
            set;
        }

        /// <summary>
        /// SyncConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-resolver.html#cfn-appsync-resolver-syncconfig
        /// Required: False
        /// UpdateType: Mutable
        /// Type: SyncConfig
        /// </summary>
        public SyncConfig SyncConfig
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
        public class LambdaConflictHandlerConfig
        {
            /// <summary>
            /// LambdaConflictHandlerArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-lambdaconflicthandlerconfig.html#cfn-appsync-resolver-lambdaconflicthandlerconfig-lambdaconflicthandlerarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LambdaConflictHandlerArn
            {
                get;
                set;
            }
        }

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

        public class SyncConfig
        {
            /// <summary>
            /// ConflictHandler
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflicthandler
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictHandler
            {
                get;
                set;
            }

            /// <summary>
            /// ConflictDetection
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-conflictdetection
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConflictDetection
            {
                get;
                set;
            }

            /// <summary>
            /// LambdaConflictHandlerConfig
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-syncconfig.html#cfn-appsync-resolver-syncconfig-lambdaconflicthandlerconfig
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LambdaConflictHandlerConfig
            /// </summary>
            public LambdaConflictHandlerConfig LambdaConflictHandlerConfig
            {
                get;
                set;
            }
        }

        public class CachingConfig
        {
            /// <summary>
            /// CachingKeys
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-cachingkeys
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic CachingKeys
            {
                get;
                set;
            }

            /// <summary>
            /// Ttl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appsync-resolver-cachingconfig.html#cfn-appsync-resolver-cachingconfig-ttl
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Ttl
            {
                get;
                set;
            }
        }
    }
}