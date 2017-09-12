namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;
    using UsagePlanPropertyTypes;

    public class UsagePlan : Humidifier.Resource
    {
        /// <summary>
        /// ApiStages
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-apistages
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ApiStage
        /// </summary>
        public List<ApiStage> ApiStages
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-description
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
        /// Quota
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-quota
        /// Required: False
        /// UpdateType: Mutable
        /// Type: QuotaSettings
        /// </summary>
        public QuotaSettings Quota
        {
            get;
            set;
        }

        /// <summary>
        /// Throttle
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-throttle
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ThrottleSettings
        /// </summary>
        public ThrottleSettings Throttle
        {
            get;
            set;
        }

        /// <summary>
        /// UsagePlanName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-usageplan.html#cfn-apigateway-usageplan-usageplanname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UsagePlanName
        {
            get;
            set;
        }
    }

    namespace UsagePlanPropertyTypes
    {
        public class ApiStage
        {
            /// <summary>
            /// ApiId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-apiid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ApiId
            {
                get;
                set;
            }

            /// <summary>
            /// Stage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-apistage.html#cfn-apigateway-usageplan-apistage-stage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Stage
            {
                get;
                set;
            }
        }

        public class ThrottleSettings
        {
            /// <summary>
            /// BurstLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-burstlimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BurstLimit
            {
                get;
                set;
            }

            /// <summary>
            /// RateLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-throttlesettings.html#cfn-apigateway-usageplan-throttlesettings-ratelimit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic RateLimit
            {
                get;
                set;
            }
        }

        public class QuotaSettings
        {
            /// <summary>
            /// Limit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-limit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Limit
            {
                get;
                set;
            }

            /// <summary>
            /// Offset
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-offset
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Offset
            {
                get;
                set;
            }

            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-apigateway-usageplan-quotasettings.html#cfn-apigateway-usageplan-quotasettings-period
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Period
            {
                get;
                set;
            }
        }
    }
}