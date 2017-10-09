namespace Humidifier.AutoScaling
{
    using System.Collections.Generic;
    using LaunchConfigurationPropertyTypes;

    public class LaunchConfiguration : Humidifier.Resource
    {
        /// <summary>
        /// AssociatePublicIpAddress
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cf-as-launchconfig-associatepubip
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AssociatePublicIpAddress
        {
            get;
            set;
        }

        /// <summary>
        /// BlockDeviceMappings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-blockdevicemappings
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BlockDeviceMapping
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get;
            set;
        }

        /// <summary>
        /// ClassicLinkVPCId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClassicLinkVPCId
        {
            get;
            set;
        }

        /// <summary>
        /// ClassicLinkVPCSecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-classiclinkvpcsecuritygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ClassicLinkVPCSecurityGroups
        {
            get;
            set;
        }

        /// <summary>
        /// EbsOptimized
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ebsoptimized
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic EbsOptimized
        {
            get;
            set;
        }

        /// <summary>
        /// IamInstanceProfile
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-iaminstanceprofile
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IamInstanceProfile
        {
            get;
            set;
        }

        /// <summary>
        /// ImageId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-imageid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ImageId
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instanceid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceId
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceMonitoring
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancemonitoring
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic InstanceMonitoring
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-instancetype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceType
        {
            get;
            set;
        }

        /// <summary>
        /// KernelId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-kernelid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KernelId
        {
            get;
            set;
        }

        /// <summary>
        /// KeyName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-keyname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KeyName
        {
            get;
            set;
        }

        /// <summary>
        /// PlacementTenancy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-placementtenancy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PlacementTenancy
        {
            get;
            set;
        }

        /// <summary>
        /// RamDiskId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-ramdiskid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RamDiskId
        {
            get;
            set;
        }

        /// <summary>
        /// SecurityGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-securitygroups
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SecurityGroups
        {
            get;
            set;
        }

        /// <summary>
        /// SpotPrice
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-spotprice
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SpotPrice
        {
            get;
            set;
        }

        /// <summary>
        /// UserData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig.html#cfn-as-launchconfig-userdata
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserData
        {
            get;
            set;
        }
    }

    namespace LaunchConfigurationPropertyTypes
    {
        public class BlockDeviceMapping
        {
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html#cfn-as-launchconfig-blockdev-mapping-devicename
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DeviceName
            {
                get;
                set;
            }

            /// <summary>
            /// Ebs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html#cfn-as-launchconfig-blockdev-mapping-ebs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: BlockDevice
            /// </summary>
            public BlockDevice Ebs
            {
                get;
                set;
            }

            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html#cfn-as-launchconfig-blockdev-mapping-nodevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic NoDevice
            {
                get;
                set;
            }

            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-mapping.html#cfn-as-launchconfig-blockdev-mapping-virtualname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VirtualName
            {
                get;
                set;
            }
        }

        public class BlockDevice
        {
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-deleteonterm
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic DeleteOnTermination
            {
                get;
                set;
            }

            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-encrypted
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Encrypted
            {
                get;
                set;
            }

            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-iops
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
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-snapshotid
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
            /// VolumeSize
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumeSize
            {
                get;
                set;
            }

            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-as-launchconfig-blockdev-template.html#cfn-as-launchconfig-blockdev-template-volumetype
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
    }
}