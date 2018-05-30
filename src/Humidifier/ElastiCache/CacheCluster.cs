namespace Humidifier.ElastiCache
{
    using System.Collections.Generic;

    public class CacheCluster : Humidifier.Resource
    {
        public static class Attributes
        {
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ElastiCache::CacheCluster";
            }
        }

        /// <summary>
        /// AZMode
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-azmode
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic AZMode
        {
            get;
            set;
        }

        /// <summary>
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-autominorversionupgrade
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
        /// CacheNodeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachenodetype
        /// Required: True
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cacheparametergroupname
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesecuritygroupnames
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-cachesubnetgroupname
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
        /// ClusterName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-clustername
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterName
        {
            get;
            set;
        }

        /// <summary>
        /// Engine
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engine
        /// Required: True
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-engineversion
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
        /// NotificationTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-notificationtopicarn
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
        /// NumCacheNodes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-numcachenodes
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic NumCacheNodes
        {
            get;
            set;
        }

        /// <summary>
        /// Port
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-port
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
        /// PreferredAvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzone
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic PreferredAvailabilityZone
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredAvailabilityZones
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredavailabilityzones
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PreferredAvailabilityZones
        {
            get;
            set;
        }

        /// <summary>
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-preferredmaintenancewindow
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
        /// SnapshotArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotarns
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotname
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotretentionlimit
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-snapshotwindow
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
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-tags
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
        /// VpcSecurityGroupIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticache-cache-cluster.html#cfn-elasticache-cachecluster-vpcsecuritygroupids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic VpcSecurityGroupIds
        {
            get;
            set;
        }
    }
}