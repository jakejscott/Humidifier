namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using StageTypes;

    public class Stage : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ApiGateway::Stage";
            }
        }

        /// <summary>
        /// AccessLogSetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-accesslogsetting
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AccessLogSetting
        /// </summary>
        public AccessLogSetting AccessLogSetting
        {
            get;
            set;
        }

        /// <summary>
        /// CacheClusterEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-cacheclusterenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CacheClusterEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// CacheClusterSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-cacheclustersize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheClusterSize
        {
            get;
            set;
        }

        /// <summary>
        /// CanarySetting
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-canarysetting
        /// Required: False
        /// UpdateType: Mutable
        /// Type: CanarySetting
        /// </summary>
        public CanarySetting CanarySetting
        {
            get;
            set;
        }

        /// <summary>
        /// ClientCertificateId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-clientcertificateid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClientCertificateId
        {
            get;
            set;
        }

        /// <summary>
        /// DeploymentId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-deploymentid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DeploymentId
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-description
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
        /// DocumentationVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-documentationversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DocumentationVersion
        {
            get;
            set;
        }

        /// <summary>
        /// MethodSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-methodsettings
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: MethodSetting
        /// </summary>
        public List<MethodSetting> MethodSettings
        {
            get;
            set;
        }

        /// <summary>
        /// RestApiId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-restapiid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RestApiId
        {
            get;
            set;
        }

        /// <summary>
        /// StageName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-stagename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StageName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-tags
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
        /// TracingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-tracingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic TracingEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Variables
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-stage.html#cfn-apigateway-stage-variables
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Map
        /// PrimitiveItemType: String
        /// </summary>
        public Dictionary<string, dynamic> Variables
        {
            get;
            set;
        }
    }

    namespace StageTypes
    {
        public class MethodSetting
        {
            /// <summary>
            /// CacheDataEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachedataencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CacheDataEncrypted
            {
                get;
                set;
            }

            /// <summary>
            /// CacheTtlInSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachettlinseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CacheTtlInSeconds
            {
                get;
                set;
            }

            /// <summary>
            /// CachingEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-cachingenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CachingEnabled
            {
                get;
                set;
            }

            /// <summary>
            /// DataTraceEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-datatraceenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DataTraceEnabled
            {
                get;
                set;
            }

            /// <summary>
            /// HttpMethod
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-httpmethod
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HttpMethod
            {
                get;
                set;
            }

            /// <summary>
            /// LoggingLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-logginglevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoggingLevel
            {
                get;
                set;
            }

            /// <summary>
            /// MetricsEnabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-metricsenabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic MetricsEnabled
            {
                get;
                set;
            }

            /// <summary>
            /// ResourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-resourcepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourcePath
            {
                get;
                set;
            }

            /// <summary>
            /// ThrottlingBurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-throttlingburstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThrottlingBurstLimit
            {
                get;
                set;
            }

            /// <summary>
            /// ThrottlingRateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apitgateway-stage-methodsetting.html#cfn-apigateway-stage-methodsetting-throttlingratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic ThrottlingRateLimit
            {
                get;
                set;
            }
        }

        public class CanarySetting
        {
            /// <summary>
            /// DeploymentId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-canarysetting.html#cfn-apigateway-stage-canarysetting-deploymentid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeploymentId
            {
                get;
                set;
            }

            /// <summary>
            /// PercentTraffic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-canarysetting.html#cfn-apigateway-stage-canarysetting-percenttraffic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic PercentTraffic
            {
                get;
                set;
            }

            /// <summary>
            /// StageVariableOverrides
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-canarysetting.html#cfn-apigateway-stage-canarysetting-stagevariableoverrides
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> StageVariableOverrides
            {
                get;
                set;
            }

            /// <summary>
            /// UseStageCache
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-canarysetting.html#cfn-apigateway-stage-canarysetting-usestagecache
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic UseStageCache
            {
                get;
                set;
            }
        }

        public class AccessLogSetting
        {
            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-accesslogsetting.html#cfn-apigateway-stage-accesslogsetting-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationArn
            {
                get;
                set;
            }

            /// <summary>
            /// Format
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-stage-accesslogsetting.html#cfn-apigateway-stage-accesslogsetting-format
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Format
            {
                get;
                set;
            }
        }
    }
}