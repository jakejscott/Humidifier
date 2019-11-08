namespace Humidifier.Glue
{
    using System.Collections.Generic;
    using SecurityConfigurationTypes;

    public class SecurityConfiguration : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Glue::SecurityConfiguration";
            }
        }

        /// <summary>
        /// EncryptionConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-securityconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: EncryptionConfiguration
        /// </summary>
        public EncryptionConfiguration EncryptionConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-glue-securityconfiguration.html#cfn-glue-securityconfiguration-name
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

    namespace SecurityConfigurationTypes
    {
        public class S3Encryption
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-s3encryption.html#cfn-glue-securityconfiguration-s3encryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn
            {
                get;
                set;
            }

            /// <summary>
            /// S3EncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-s3encryption.html#cfn-glue-securityconfiguration-s3encryption-s3encryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic S3EncryptionMode
            {
                get;
                set;
            }
        }

        public class CloudWatchEncryption
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn
            {
                get;
                set;
            }

            /// <summary>
            /// CloudWatchEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-cloudwatchencryption.html#cfn-glue-securityconfiguration-cloudwatchencryption-cloudwatchencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CloudWatchEncryptionMode
            {
                get;
                set;
            }
        }

        public class EncryptionConfiguration
        {
            /// <summary>
            /// S3Encryptions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-s3encryptions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: S3Encryptions
            /// </summary>
            public S3Encryptions S3Encryptions
            {
                get;
                set;
            }

            /// <summary>
            /// CloudWatchEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-cloudwatchencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CloudWatchEncryption
            /// </summary>
            public CloudWatchEncryption CloudWatchEncryption
            {
                get;
                set;
            }

            /// <summary>
            /// JobBookmarksEncryption
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-encryptionconfiguration.html#cfn-glue-securityconfiguration-encryptionconfiguration-jobbookmarksencryption
            /// Required: False
            /// UpdateType: Mutable
            /// Type: JobBookmarksEncryption
            /// </summary>
            public JobBookmarksEncryption JobBookmarksEncryption
            {
                get;
                set;
            }
        }

        public class JobBookmarksEncryption
        {
            /// <summary>
            /// KmsKeyArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-jobbookmarksencryption.html#cfn-glue-securityconfiguration-jobbookmarksencryption-kmskeyarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KmsKeyArn
            {
                get;
                set;
            }

            /// <summary>
            /// JobBookmarksEncryptionMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-glue-securityconfiguration-jobbookmarksencryption.html#cfn-glue-securityconfiguration-jobbookmarksencryption-jobbookmarksencryptionmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobBookmarksEncryptionMode
            {
                get;
                set;
            }
        }

        public class S3Encryptions
        {
        }
    }
}