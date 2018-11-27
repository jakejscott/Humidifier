namespace Humidifier.RDS
{
    using System.Collections.Generic;
    using DBInstanceTypes;

    public class DBInstance : Humidifier.Resource
    {
        public static class Attributes
        {
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::RDS::DBInstance";
            }
        }

        /// <summary>
        /// AllocatedStorage
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allocatedstorage
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AllocatedStorage
        {
            get;
            set;
        }

        /// <summary>
        /// AllowMajorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-allowmajorversionupgrade
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AllowMajorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-autominorversionupgrade
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-availabilityzone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>
        /// BackupRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-backupretentionperiod
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic BackupRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// CharacterSetName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-charactersetname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CharacterSetName
        {
            get;
            set;
        }

        /// <summary>
        /// CopyTagsToSnapshot
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-copytagstosnapshot
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic CopyTagsToSnapshot
        {
            get;
            set;
        }

        /// <summary>
        /// DBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbclusteridentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBClusterIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// DBInstanceClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceclass
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBInstanceClass
        {
            get;
            set;
        }

        /// <summary>
        /// DBInstanceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbinstanceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBInstanceIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// DBName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBName
        {
            get;
            set;
        }

        /// <summary>
        /// DBParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbparametergroupname
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBParameterGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// DBSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic DBSecurityGroups
        {
            get;
            set;
        }

        /// <summary>
        /// DBSnapshotIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsnapshotidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBSnapshotIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// DBSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-dbsubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// DeleteAutomatedBackups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deleteautomatedbackups
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeleteAutomatedBackups
        {
            get;
            set;
        }

        /// <summary>
        /// DeletionProtection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-deletionprotection
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DeletionProtection
        {
            get;
            set;
        }

        /// <summary>
        /// Domain
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domain
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Domain
        {
            get;
            set;
        }

        /// <summary>
        /// DomainIAMRoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-domainiamrolename
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DomainIAMRoleName
        {
            get;
            set;
        }

        /// <summary>
        /// EnableCloudwatchLogsExports
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enablecloudwatchlogsexports
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic EnableCloudwatchLogsExports
        {
            get;
            set;
        }

        /// <summary>
        /// EnableIAMDatabaseAuthentication
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableiamdatabaseauthentication
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnableIAMDatabaseAuthentication
        {
            get;
            set;
        }

        /// <summary>
        /// EnablePerformanceInsights
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-enableperformanceinsights
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EnablePerformanceInsights
        {
            get;
            set;
        }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engine
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Engine
        {
            get;
            set;
        }

        /// <summary>
        /// EngineVersion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-engineversion
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineVersion
        {
            get;
            set;
        }

        /// <summary>
        /// Iops
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-iops
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Iops
        {
            get;
            set;
        }

        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-kmskeyid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// LicenseModel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-licensemodel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LicenseModel
        {
            get;
            set;
        }

        /// <summary>
        /// MasterUserPassword
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masteruserpassword
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MasterUserPassword
        {
            get;
            set;
        }

        /// <summary>
        /// MasterUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-masterusername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MasterUsername
        {
            get;
            set;
        }

        /// <summary>
        /// MonitoringInterval
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringinterval
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MonitoringInterval
        {
            get;
            set;
        }

        /// <summary>
        /// MonitoringRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-monitoringrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MonitoringRoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// MultiAZ
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-multiaz
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic MultiAZ
        {
            get;
            set;
        }

        /// <summary>
        /// OptionGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-optiongroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OptionGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// PerformanceInsightsKMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightskmskeyid
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic PerformanceInsightsKMSKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// PerformanceInsightsRetentionPeriod
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-performanceinsightsretentionperiod
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic PerformanceInsightsRetentionPeriod
        {
            get;
            set;
        }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Port
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredBackupWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredbackupwindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredBackupWindow
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>
        /// ProcessorFeatures
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-processorfeatures
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ProcessorFeature
        /// </summary>
        public List<ProcessorFeature> ProcessorFeatures
        {
            get;
            set;
        }

        /// <summary>
        /// PromotionTier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-promotiontier
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic PromotionTier
        {
            get;
            set;
        }

        /// <summary>
        /// PubliclyAccessible
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-publiclyaccessible
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic PubliclyAccessible
        {
            get;
            set;
        }

        /// <summary>
        /// SourceDBInstanceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourcedbinstanceidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceDBInstanceIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// SourceRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-sourceregion
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceRegion
        {
            get;
            set;
        }

        /// <summary>
        /// StorageEncrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storageencrypted
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic StorageEncrypted
        {
            get;
            set;
        }

        /// <summary>
        /// StorageType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-storagetype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic StorageType
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-tags
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

        /// <summary>
        /// Timezone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-timezone
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Timezone
        {
            get;
            set;
        }

        /// <summary>
        /// VPCSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-database-instance.html#cfn-rds-dbinstance-vpcsecuritygroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic VPCSecurityGroups
        {
            get;
            set;
        }
    }

    namespace DBInstanceTypes
    {
        public class ProcessorFeature
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstance-processorfeature.html#cfn-rds-dbinstance-processorfeature-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-rds-dbinstance-processorfeature.html#cfn-rds-dbinstance-processorfeature-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }
    }
}