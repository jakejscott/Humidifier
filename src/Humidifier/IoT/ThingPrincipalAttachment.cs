namespace Humidifier.IoT
{
    using System.Collections.Generic;
    using ThingPrincipalAttachmentPropertyTypes;

    public class ThingPrincipalAttachment : Humidifier.Resource
    {
        /// <summary>
        /// Principal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-principal
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Principal
        {
            get;
            set;
        }

        /// <summary>
        /// ThingName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iot-thingprincipalattachment.html#cfn-iot-thingprincipalattachment-thingname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ThingName
        {
            get;
            set;
        }
    }

    namespace ThingPrincipalAttachmentPropertyTypes
    {
    }
}