namespace Humidifier.KMS
{
    using System.Collections.Generic;
    using KeyPropertyTypes;

    public class Key : Humidifier.Resource
    {
        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html#cfn-kms-key-description
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
        /// EnableKeyRotation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html#cfn-kms-key-enablekeyrotation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? EnableKeyRotation
        {
            get;
            set;
        }

        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html#cfn-kms-key-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// KeyPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html#cfn-kms-key-keypolicy
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic KeyPolicy
        {
            get;
            set;
        }

        /// <summary>
        /// KeyUsage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-kms-key.html#cfn-kms-key-keyusage
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyUsage
        {
            get;
            set;
        }
    }

    namespace KeyPropertyTypes
    {
    }
}