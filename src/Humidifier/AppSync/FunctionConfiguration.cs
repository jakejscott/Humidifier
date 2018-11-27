namespace Humidifier.AppSync
{
    using System.Collections.Generic;

    public class FunctionConfiguration : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string FunctionId =  "FunctionId" ;
            public static string FunctionArn =  "FunctionArn" ;
            public static string DataSourceName =  "DataSourceName" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppSync::FunctionConfiguration";
            }
        }

        /// <summary>
        /// ResponseMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-responsemappingtemplates3location
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
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-description
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
        /// DataSourceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-datasourcename
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-requestmappingtemplate
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-responsemappingtemplate
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
        /// FunctionVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-functionversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionVersion
        {
            get;
            set;
        }

        /// <summary>
        /// RequestMappingTemplateS3Location
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-requestmappingtemplates3location
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-apiid
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
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appsync-functionconfiguration.html#cfn-appsync-functionconfiguration-name
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }
}