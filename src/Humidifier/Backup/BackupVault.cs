namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using BackupVaultTypes;

    public class BackupVault : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string BackupVaultName =  "BackupVaultName" ;
            public static string BackupVaultArn =  "BackupVaultArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Backup::BackupVault";
            }
        }

        /// <summary>
        /// BackupVaultTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-backupvaulttags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic BackupVaultTags
        {
            get;
            set;
        }

        /// <summary>
        /// BackupVaultName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-backupvaultname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BackupVaultName
        {
            get;
            set;
        }

        /// <summary>
        /// EncryptionKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-encryptionkeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EncryptionKeyArn
        {
            get;
            set;
        }

        /// <summary>
        /// Notifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-notifications
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NotificationObjectType
        /// </summary>
        public NotificationObjectType Notifications
        {
            get;
            set;
        }

        /// <summary>
        /// AccessPolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupvault.html#cfn-backup-backupvault-accesspolicy
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AccessPolicy
        {
            get;
            set;
        }
    }

    namespace BackupVaultTypes
    {
        public class NotificationObjectType
        {
            /// <summary>
            /// SNSTopicArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-snstopicarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SNSTopicArn
            {
                get;
                set;
            }

            /// <summary>
            /// BackupVaultEvents
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupvault-notificationobjecttype.html#cfn-backup-backupvault-notificationobjecttype-backupvaultevents
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic BackupVaultEvents
            {
                get;
                set;
            }
        }
    }
}