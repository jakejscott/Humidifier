namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;
    using ReplicationGroupPropertyTypes;

    public class ReplicationGroup : Humidifier.Resource
    {
        public static class Attributes
        {
        }

        /// <summary>
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-autominorversionupgrade
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutoMinorVersionUpgrade
        {
            get;
            set;
        }

        /// <summary>
        /// AutomaticFailoverEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-automaticfailoverenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AutomaticFailoverEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachenodetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheNodeType
        {
            get;
            set;
        }

        /// <summary>
        /// CacheParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cacheparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheParameterGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// CacheSecurityGroupNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachesecuritygroupnames
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic CacheSecurityGroupNames
        {
            get;
            set;
        }

        /// <summary>
        /// CacheSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-cachesubnetgroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CacheSubnetGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engine
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-engineversion
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EngineVersion
        {
            get;
            set;
        }

        /// <summary>
        /// NodeGroupConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-nodegroupconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: NodeGroupConfiguration
        /// </summary>
        public List<NodeGroupConfiguration> NodeGroupConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// NotificationTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-notificationtopicarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NotificationTopicArn
        {
            get;
            set;
        }

        /// <summary>
        /// NumCacheClusters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numcacheclusters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumCacheClusters
        {
            get;
            set;
        }

        /// <summary>
        /// NumNodeGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-numnodegroups
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumNodeGroups
        {
            get;
            set;
        }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-port
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Port
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredCacheClusterAZs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredcacheclusterazs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PreferredCacheClusterAZs
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-preferredmaintenancewindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredMaintenanceWindow
        {
            get;
            set;
        }

        /// <summary>
        /// PrimaryClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-primaryclusterid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PrimaryClusterId
        {
            get;
            set;
        }

        /// <summary>
        /// ReplicasPerNodeGroup
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicaspernodegroup
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic ReplicasPerNodeGroup
        {
            get;
            set;
        }

        /// <summary>
        /// ReplicationGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationGroupDescription
        {
            get;
            set;
        }

        /// <summary>
        /// ReplicationGroupId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-replicationgroupid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationGroupId
        {
            get;
            set;
        }

        /// <summary>
        /// SecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-securitygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroupIds
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshotArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotarns
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SnapshotArns
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshotName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshotName
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshotRetentionLimit
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotretentionlimit
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic SnapshotRetentionLimit
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshotWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshotwindow
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshotWindow
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshottingClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-snapshottingclusterid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshottingClusterId
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticache-replicationgroup.html#cfn-elasticache-replicationgroup-tags
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

    namespace ReplicationGroupPropertyTypes
    {
        public class NodeGroupConfiguration
        {
            /// <summary>
            /// PrimaryAvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-primaryavailabilityzone
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrimaryAvailabilityZone
            {
                get;
                set;
            }

            /// <summary>
            /// ReplicaAvailabilityZones
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicaavailabilityzones
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ReplicaAvailabilityZones
            {
                get;
                set;
            }

            /// <summary>
            /// ReplicaCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-replicacount
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ReplicaCount
            {
                get;
                set;
            }

            /// <summary>
            /// Slots
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-replicationgroup-nodegroupconfiguration.html#cfn-elasticache-replicationgroup-nodegroupconfiguration-slots
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Slots
            {
                get;
                set;
            }
        }
    }
}