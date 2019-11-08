namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using GroupTypes;

    public class Group : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string RoleAttachedAt =  "RoleAttachedAt" ;
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string RoleArn =  "RoleArn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Greengrass::Group";
            }
        }

        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: GroupVersion
        /// </summary>
        public GroupVersion InitialVersion
        {
            get;
            set;
        }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-rolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-tags
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-group.html#cfn-greengrass-group-name
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

    namespace GroupTypes
    {
        public class GroupVersion
        {
            /// <summary>
            /// LoggerDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-loggerdefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LoggerDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// DeviceDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-devicedefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// FunctionDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-functiondefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FunctionDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// CoreDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-coredefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CoreDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// ResourceDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-resourcedefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ResourceDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// ConnectorDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-connectordefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorDefinitionVersionArn
            {
                get;
                set;
            }

            /// <summary>
            /// SubscriptionDefinitionVersionArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-group-groupversion.html#cfn-greengrass-group-groupversion-subscriptiondefinitionversionarn
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubscriptionDefinitionVersionArn
            {
                get;
                set;
            }
        }
    }
}