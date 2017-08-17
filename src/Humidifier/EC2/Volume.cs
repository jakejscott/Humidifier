namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using VolumePropertyTypes;

    public class Volume : Humidifier.Resource
    {
        /// <summary>
        /// AutoEnableIO
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-autoenableio
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? AutoEnableIO
        {
            get;
            set;
        }

        /// <summary>
        /// AvailabilityZone
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-availabilityzone
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AvailabilityZone
        {
            get;
            set;
        }

        /// <summary>
        /// Encrypted
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-encrypted
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? Encrypted
        {
            get;
            set;
        }

        /// <summary>
        /// Iops
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-iops
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? Iops
        {
            get;
            set;
        }

        /// <summary>
        /// KmsKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KmsKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// Size
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-size
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? Size
        {
            get;
            set;
        }

        /// <summary>
        /// SnapshotId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-snapshotid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnapshotId
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-tags
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
        /// VolumeType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-ebs-volume.html#cfn-ec2-ebs-volume-volumetype
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic VolumeType
        {
            get;
            set;
        }
    }

    namespace VolumePropertyTypes
    {
    }
}