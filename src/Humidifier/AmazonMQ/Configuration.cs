namespace Humidifier.AmazonMQ
{
    using System.Collections.Generic;

    public class Configuration : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Revision =  "Revision" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AmazonMQ::Configuration";
            }
        }

        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html#cfn-amazonmq-configuration-engineversion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html#cfn-amazonmq-configuration-description
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
        /// EngineType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html#cfn-amazonmq-configuration-enginetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineType
        {
            get;
            set;
        }

        /// <summary>
        /// Data
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html#cfn-amazonmq-configuration-data
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Data
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-amazonmq-configuration.html#cfn-amazonmq-configuration-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }
}