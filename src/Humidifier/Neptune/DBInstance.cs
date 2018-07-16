namespace Humidifier.Neptune
{
    using System.Collections.Generic;

    public class DBInstance : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Endpoint =  "Endpoint" ;
            public static string Port =  "Port" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Neptune::DBInstance";
            }
        }

        /// <summary>
        /// DBParameterGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbparametergroupname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DBParameterGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// DBInstanceClass
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbinstanceclass
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
        /// AllowMajorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-allowmajorversionupgrade
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
        /// DBClusterIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbclusteridentifier
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
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-availabilityzone
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
        /// PreferredMaintenanceWindow
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-preferredmaintenancewindow
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
        /// AutoMinorVersionUpgrade
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-autominorversionupgrade
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
        /// DBSubnetGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbsubnetgroupname
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
        /// DBInstanceIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbinstanceidentifier
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
        /// DBSnapshotIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-dbsnapshotidentifier
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
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-neptune-dbinstance.html#cfn-neptune-dbinstance-tags
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
}