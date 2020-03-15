namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using BackupPlanTypes;

    public class BackupPlan : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string VersionId =  "VersionId" ;
            public static string BackupPlanId =  "BackupPlanId" ;
            public static string BackupPlanArn =  "BackupPlanArn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Backup::BackupPlan";
            }
        }

        /// <summary>
        /// BackupPlan
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupplan.html#cfn-backup-backupplan-backupplan
        /// Required: True
        /// UpdateType: Mutable
        /// Type: BackupPlanResourceType
        /// </summary>
        public BackupPlanResourceType BackupPlan_
        {
            get;
            set;
        }

        /// <summary>
        /// BackupPlanTags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupplan.html#cfn-backup-backupplan-backupplantags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic BackupPlanTags
        {
            get;
            set;
        }
    }

    namespace BackupPlanTypes
    {
        public class CopyActionResourceType
        {
            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public LifecycleResourceType Lifecycle
            {
                get;
                set;
            }

            /// <summary>
            /// DestinationBackupVaultArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-copyactionresourcetype.html#cfn-backup-backupplan-copyactionresourcetype-destinationbackupvaultarn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationBackupVaultArn
            {
                get;
                set;
            }
        }

        public class LifecycleResourceType
        {
            /// <summary>
            /// DeleteAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-deleteafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic DeleteAfterDays
            {
                get;
                set;
            }

            /// <summary>
            /// MoveToColdStorageAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-lifecycleresourcetype.html#cfn-backup-backupplan-lifecycleresourcetype-movetocoldstorageafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic MoveToColdStorageAfterDays
            {
                get;
                set;
            }
        }

        public class BackupRuleResourceType
        {
            /// <summary>
            /// CompletionWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-completionwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic CompletionWindowMinutes
            {
                get;
                set;
            }

            /// <summary>
            /// ScheduleExpression
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-scheduleexpression
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ScheduleExpression
            {
                get;
                set;
            }

            /// <summary>
            /// RecoveryPointTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-recoverypointtags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic RecoveryPointTags
            {
                get;
                set;
            }

            /// <summary>
            /// CopyActions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-copyactions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: CopyActionResourceType
            /// </summary>
            public List<CopyActionResourceType> CopyActions
            {
                get;
                set;
            }

            /// <summary>
            /// Lifecycle
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-lifecycle
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LifecycleResourceType
            /// </summary>
            public LifecycleResourceType Lifecycle
            {
                get;
                set;
            }

            /// <summary>
            /// TargetBackupVault
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-targetbackupvault
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetBackupVault
            {
                get;
                set;
            }

            /// <summary>
            /// StartWindowMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-startwindowminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic StartWindowMinutes
            {
                get;
                set;
            }

            /// <summary>
            /// RuleName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupruleresourcetype.html#cfn-backup-backupplan-backupruleresourcetype-rulename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RuleName
            {
                get;
                set;
            }
        }

        public class BackupPlanResourceType
        {
            /// <summary>
            /// BackupPlanName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BackupPlanName
            {
                get;
                set;
            }

            /// <summary>
            /// BackupPlanRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupplan-backupplanresourcetype.html#cfn-backup-backupplan-backupplanresourcetype-backupplanrule
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BackupRuleResourceType
            /// </summary>
            public List<BackupRuleResourceType> BackupPlanRule
            {
                get;
                set;
            }
        }
    }
}