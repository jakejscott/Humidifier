namespace Humidifier.IoTEvents
{
    using System.Collections.Generic;
    using InputTypes;

    public class Input : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IoTEvents::Input";
            }
        }

        /// <summary>
        /// InputDefinition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputdefinition
        /// Required: False
        /// UpdateType: Mutable
        /// Type: InputDefinition
        /// </summary>
        public InputDefinition InputDefinition
        {
            get;
            set;
        }

        /// <summary>
        /// InputName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InputName
        {
            get;
            set;
        }

        /// <summary>
        /// InputDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-inputdescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InputDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iotevents-input.html#cfn-iotevents-input-tags
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
    }

    namespace InputTypes
    {
        public class Attribute
        {
            /// <summary>
            /// JsonPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-attribute.html#cfn-iotevents-input-attribute-jsonpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JsonPath
            {
                get;
                set;
            }
        }

        public class InputDefinition
        {
            /// <summary>
            /// Attributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iotevents-input-inputdefinition.html#cfn-iotevents-input-inputdefinition-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Attribute
            /// </summary>
            public List<Attribute> Attributes_
            {
                get;
                set;
            }
        }
    }
}