namespace Humidifier.IoTThingsGraph
{
    using System.Collections.Generic;
    using FlowTemplateTypes;

    public class FlowTemplate : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTThingsGraph::FlowTemplate";
            }
        }

        /// <summary>
        /// CompatibleNamespaceVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotthingsgraph-flowtemplate.html#cfn-iotthingsgraph-flowtemplate-compatiblenamespaceversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Double
        /// </summary>
        public dynamic CompatibleNamespaceVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Definition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotthingsgraph-flowtemplate.html#cfn-iotthingsgraph-flowtemplate-definition
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DefinitionDocument
        /// </summary>
        public DefinitionDocument Definition
        {
            get;
            set;
        }
    }

    namespace FlowTemplateTypes
    {
        public class DefinitionDocument
        {
            /// <summary>
            /// Language
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotthingsgraph-flowtemplate-definitiondocument.html#cfn-iotthingsgraph-flowtemplate-definitiondocument-language
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Language
            {
                get;
                set;
            }

            /// <summary>
            /// Text
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotthingsgraph-flowtemplate-definitiondocument.html#cfn-iotthingsgraph-flowtemplate-definitiondocument-text
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Text
            {
                get;
                set;
            }
        }
    }
}