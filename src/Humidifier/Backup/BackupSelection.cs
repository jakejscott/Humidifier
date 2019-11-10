namespace Humidifier.Backup
{
    using System.Collections.Generic;
    using BackupSelectionTypes;

    public class BackupSelection : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string BackupPlanId =  "BackupPlanId" ;
            public static string SelectionId =  "SelectionId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Backup::BackupSelection";
            }
        }

        /// <summary>
        /// BackupSelection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupselection.html#cfn-backup-backupselection-backupselection
        /// Required: True
        /// UpdateType: Immutable
        /// Type: BackupSelectionResourceType
        /// </summary>
        public BackupSelectionResourceType BackupSelection_
        {
            get;
            set;
        }

        /// <summary>
        /// BackupPlanId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-backup-backupselection.html#cfn-backup-backupselection-backupplanid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BackupPlanId
        {
            get;
            set;
        }
    }

    namespace BackupSelectionTypes
    {
        public class BackupSelectionResourceType
        {
            /// <summary>
            /// ListOfTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-listoftags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ConditionResourceType
            /// </summary>
            public List<ConditionResourceType> ListOfTags
            {
                get;
                set;
            }

            /// <summary>
            /// SelectionName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-selectionname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SelectionName
            {
                get;
                set;
            }

            /// <summary>
            /// IamRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-iamrolearn
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamRoleArn
            {
                get;
                set;
            }

            /// <summary>
            /// Resources
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-backupselectionresourcetype.html#cfn-backup-backupselection-backupselectionresourcetype-resources
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Resources
            {
                get;
                set;
            }
        }

        public class ConditionResourceType
        {
            /// <summary>
            /// ConditionValue
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditionvalue
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionValue
            {
                get;
                set;
            }

            /// <summary>
            /// ConditionKey
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditionkey
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionKey
            {
                get;
                set;
            }

            /// <summary>
            /// ConditionType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-backup-backupselection-conditionresourcetype.html#cfn-backup-backupselection-conditionresourcetype-conditiontype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ConditionType
            {
                get;
                set;
            }
        }
    }
}