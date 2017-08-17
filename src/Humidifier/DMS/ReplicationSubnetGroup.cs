namespace Humidifier.DMS
{
    using System.Collections.Generic;
    using ReplicationSubnetGroupPropertyTypes;

    public class ReplicationSubnetGroup : Humidifier.Resource
    {
        /// <summary>
        /// ReplicationSubnetGroupDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html#cfn-dms-replicationsubnetgroup-replicationsubnetgroupdescription
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationSubnetGroupDescription
        {
            get;
            set;
        }

        /// <summary>
        /// ReplicationSubnetGroupIdentifier
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html#cfn-dms-replicationsubnetgroup-replicationsubnetgroupidentifier
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReplicationSubnetGroupIdentifier
        {
            get;
            set;
        }

        /// <summary>
        /// SubnetIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html#cfn-dms-replicationsubnetgroup-subnetids
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> SubnetIds
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dms-replicationsubnetgroup.html#cfn-dms-replicationsubnetgroup-tags
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }

    namespace ReplicationSubnetGroupPropertyTypes
    {
    }
}