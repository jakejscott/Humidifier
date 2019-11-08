namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using DataCatalogEncryptionSettingsTypes;

    public class DataCatalogEncryptionSettings : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Glue::DataCatalogEncryptionSettings";
            }
        }

        /// <summary>
        /// DataCatalogEncryptionSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataCatalogEncryptionSettings
        /// </summary>
        public DataCatalogEncryptionSettings DataCatalogEncryptionSettings_
        {
            get;
            set;
        }

        /// <summary>
        /// CatalogId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-catalogid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CatalogId
        {
            get;
            set;
        }
    }

    namespace DataCatalogEncryptionSettingsTypes
    {
        public class DataCatalogEncryptionSettings
        {
            /// <summary>
            /// ConnectionPasswordEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-connectionpasswordencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ConnectionPasswordEncryption
            /// </summary>
            public ConnectionPasswordEncryption ConnectionPasswordEncryption
            {
                get;
                set;
            }

            /// <summary>
            /// EncryptionAtRest
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-datacatalogencryptionsettings.html#cfn-glue-datacatalogencryptionsettings-datacatalogencryptionsettings-encryptionatrest
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EncryptionAtRest
            /// </summary>
            public EncryptionAtRest EncryptionAtRest
            {
                get;
                set;
            }
        }

        public class EncryptionAtRest
        {
            /// <summary>
            /// CatalogEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-catalogencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CatalogEncryptionMode
            {
                get;
                set;
            }

            /// <summary>
            /// SseAwsKmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-encryptionatrest.html#cfn-glue-datacatalogencryptionsettings-encryptionatrest-sseawskmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SseAwsKmsKeyId
            {
                get;
                set;
            }
        }

        public class ConnectionPasswordEncryption
        {
            /// <summary>
            /// ReturnConnectionPasswordEncrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-returnconnectionpasswordencrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReturnConnectionPasswordEncrypted
            {
                get;
                set;
            }

            /// <summary>
            /// KmsKeyId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-datacatalogencryptionsettings-connectionpasswordencryption.html#cfn-glue-datacatalogencryptionsettings-connectionpasswordencryption-kmskeyid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyId
            {
                get;
                set;
            }
        }
    }
}