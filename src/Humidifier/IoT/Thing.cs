namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using ThingPropertyTypes;

    public class Thing : IResource
    {
        /// <summary>
        /// AttributePayload
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-attributepayload
        /// Required: False
        /// UpdateType: Mutable
        /// Type: AttributePayload
        /// </summary>
        public AttributePayload AttributePayload
        {
            get;
            set;
        }

        /// <summary>
        /// ThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thing.html#cfn-iot-thing-thingname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThingName
        {
            get;
            set;
        }
    }

    namespace ThingPropertyTypes
    {
        public class AttributePayload
        {
            /// <summary>
            /// Attributes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iot-thing-attributepayload.html#cfn-iot-thing-attributepayload-attributes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> Attributes
            {
                get;
                set;
            }
        }
    }
}