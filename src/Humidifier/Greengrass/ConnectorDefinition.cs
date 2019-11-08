namespace Humidifier.Greengrass
{
    using System.Collections.Generic;
    using ConnectorDefinitionTypes;

    public class ConnectorDefinition : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string LatestVersionArn =  "LatestVersionArn" ;
            public static string Id =  "Id" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Greengrass::ConnectorDefinition";
            }
        }

        /// <summary>
        /// InitialVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html#cfn-greengrass-connectordefinition-initialversion
        /// Required: False
        /// UpdateType: Immutable
        /// Type: ConnectorDefinitionVersion
        /// </summary>
        public ConnectorDefinitionVersion InitialVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html#cfn-greengrass-connectordefinition-tags
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-greengrass-connectordefinition.html#cfn-greengrass-connectordefinition-name
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

    namespace ConnectorDefinitionTypes
    {
        public class ConnectorDefinitionVersion
        {
            /// <summary>
            /// Connectors
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connectordefinitionversion.html#cfn-greengrass-connectordefinition-connectordefinitionversion-connectors
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Connector
            /// </summary>
            public List<Connector> Connectors
            {
                get;
                set;
            }
        }

        public class Connector
        {
            /// <summary>
            /// ConnectorArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-connectorarn
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConnectorArn
            {
                get;
                set;
            }

            /// <summary>
            /// Parameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-parameters
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Parameters
            {
                get;
                set;
            }

            /// <summary>
            /// Id
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-greengrass-connectordefinition-connector.html#cfn-greengrass-connectordefinition-connector-id
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Id
            {
                get;
                set;
            }
        }
    }
}