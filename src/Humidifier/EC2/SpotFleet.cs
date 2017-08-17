namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using SpotFleetPropertyTypes;

    public class SpotFleet : Humidifier.Resource
    {
        /// <summary>
        /// SpotFleetRequestConfigData
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-spotfleet.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata
        /// Required: True
        /// UpdateType: Conditional
        /// Type: SpotFleetRequestConfigData
        /// </summary>
        public SpotFleetRequestConfigData SpotFleetRequestConfigData
        {
            get;
            set;
        }
    }

    namespace SpotFleetPropertyTypes
    {
        public class IamInstanceProfileSpecification
        {
            /// <summary>
            /// Arn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-iaminstanceprofile.html#cfn-ec2-spotfleet-iaminstanceprofilespecification-arn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Arn
            {
                get;
                set;
            }
        }

        public class InstanceNetworkInterfaceSpecification
        {
            /// <summary>
            /// AssociatePublicIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-associatepublicipaddress
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? AssociatePublicIpAddress
            {
                get;
                set;
            }

            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-deleteontermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? DeleteOnTermination
            {
                get;
                set;
            }

            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-description
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Description
            {
                get;
                set;
            }

            /// <summary>
            /// DeviceIndex
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-deviceindex
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? DeviceIndex
            {
                get;
                set;
            }

            /// <summary>
            /// Groups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-groups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public List<dynamic> Groups
            {
                get;
                set;
            }

            /// <summary>
            /// Ipv6AddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-ipv6addresscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? Ipv6AddressCount
            {
                get;
                set;
            }

            /// <summary>
            /// Ipv6Addresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-ipv6addresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InstanceIpv6Address
            /// </summary>
            public List<InstanceIpv6Address> Ipv6Addresses
            {
                get;
                set;
            }

            /// <summary>
            /// NetworkInterfaceId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-networkinterfaceid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NetworkInterfaceId
            {
                get;
                set;
            }

            /// <summary>
            /// PrivateIpAddresses
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-privateipaddresses
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PrivateIpAddressSpecification
            /// </summary>
            public List<PrivateIpAddressSpecification> PrivateIpAddresses
            {
                get;
                set;
            }

            /// <summary>
            /// SecondaryPrivateIpAddressCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-secondaryprivateipaddresscount
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? SecondaryPrivateIpAddressCount
            {
                get;
                set;
            }

            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces.html#cfn-ec2-spotfleet-instancenetworkinterfacespecification-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId
            {
                get;
                set;
            }
        }

        public class PrivateIpAddressSpecification
        {
            /// <summary>
            /// Primary
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces-privateipaddresses.html#cfn-ec2-spotfleet-privateipaddressspecification-primary
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? Primary
            {
                get;
                set;
            }

            /// <summary>
            /// PrivateIpAddress
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-networkinterfaces-privateipaddresses.html#cfn-ec2-spotfleet-privateipaddressspecification-privateipaddress
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PrivateIpAddress
            {
                get;
                set;
            }
        }

        public class InstanceIpv6Address
        {
            /// <summary>
            /// Ipv6Address
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-instanceipv6address.html#cfn-ec2-spotfleet-instanceipv6address-ipv6address
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ipv6Address
            {
                get;
                set;
            }
        }

        public class SpotFleetLaunchSpecification
        {
            /// <summary>
            /// BlockDeviceMappings
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-blockdevicemappings
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: BlockDeviceMapping
            /// </summary>
            public List<BlockDeviceMapping> BlockDeviceMappings
            {
                get;
                set;
            }

            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? EbsOptimized
            {
                get;
                set;
            }

            /// <summary>
            /// IamInstanceProfile
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-iaminstanceprofile
            /// Required: False
            /// UpdateType: Mutable
            /// Type: IamInstanceProfileSpecification
            /// </summary>
            public IamInstanceProfileSpecification IamInstanceProfile
            {
                get;
                set;
            }

            /// <summary>
            /// ImageId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-imageid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ImageId
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType
            {
                get;
                set;
            }

            /// <summary>
            /// KernelId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-kernelid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KernelId
            {
                get;
                set;
            }

            /// <summary>
            /// KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-keyname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic KeyName
            {
                get;
                set;
            }

            /// <summary>
            /// Monitoring
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-monitoring
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotFleetMonitoring
            /// </summary>
            public SpotFleetMonitoring Monitoring
            {
                get;
                set;
            }

            /// <summary>
            /// NetworkInterfaces
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-networkinterfaces
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: InstanceNetworkInterfaceSpecification
            /// </summary>
            public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
            {
                get;
                set;
            }

            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-placement
            /// Required: False
            /// UpdateType: Mutable
            /// Type: SpotPlacement
            /// </summary>
            public SpotPlacement Placement
            {
                get;
                set;
            }

            /// <summary>
            /// RamdiskId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-ramdiskid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RamdiskId
            {
                get;
                set;
            }

            /// <summary>
            /// SecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-securitygroups
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: GroupIdentifier
            /// </summary>
            public List<GroupIdentifier> SecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// SpotPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-spotprice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpotPrice
            {
                get;
                set;
            }

            /// <summary>
            /// SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-subnetid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SubnetId
            {
                get;
                set;
            }

            /// <summary>
            /// UserData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-userdata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic UserData
            {
                get;
                set;
            }

            /// <summary>
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications.html#cfn-ec2-spotfleet-spotfleetlaunchspecification-weightedcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public double ? WeightedCapacity
            {
                get;
                set;
            }
        }

        public class GroupIdentifier
        {
            /// <summary>
            /// GroupId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-securitygroups.html#cfn-ec2-spotfleet-groupidentifier-groupid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupId
            {
                get;
                set;
            }
        }

        public class SpotPlacement
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-placement.html#cfn-ec2-spotfleet-spotplacement-availabilityzone
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone
            {
                get;
                set;
            }

            /// <summary>
            /// GroupName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-placement.html#cfn-ec2-spotfleet-spotplacement-groupname
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic GroupName
            {
                get;
                set;
            }
        }

        public class SpotFleetRequestConfigData
        {
            /// <summary>
            /// AllocationStrategy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-allocationstrategy
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AllocationStrategy
            {
                get;
                set;
            }

            /// <summary>
            /// ExcessCapacityTerminationPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-excesscapacityterminationpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ExcessCapacityTerminationPolicy
            {
                get;
                set;
            }

            /// <summary>
            /// IamFleetRole
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-iamfleetrole
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IamFleetRole
            {
                get;
                set;
            }

            /// <summary>
            /// LaunchSpecifications
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications
            /// Required: True
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: SpotFleetLaunchSpecification
            /// </summary>
            public List<SpotFleetLaunchSpecification> LaunchSpecifications
            {
                get;
                set;
            }

            /// <summary>
            /// SpotPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-spotprice
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SpotPrice
            {
                get;
                set;
            }

            /// <summary>
            /// TargetCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-targetcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int TargetCapacity
            {
                get;
                set;
            }

            /// <summary>
            /// TerminateInstancesWithExpiration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-terminateinstanceswithexpiration
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? TerminateInstancesWithExpiration
            {
                get;
                set;
            }

            /// <summary>
            /// ValidFrom
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-validfrom
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValidFrom
            {
                get;
                set;
            }

            /// <summary>
            /// ValidUntil
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata.html#cfn-ec2-spotfleet-spotfleetrequestconfigdata-validuntil
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ValidUntil
            {
                get;
                set;
            }
        }

        public class EbsBlockDevice
        {
            /// <summary>
            /// DeleteOnTermination
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-deleteontermination
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? DeleteOnTermination
            {
                get;
                set;
            }

            /// <summary>
            /// Encrypted
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-encrypted
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-iops
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
            /// SnapshotId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-snapshotid
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-volumesize
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? VolumeSize
            {
                get;
                set;
            }

            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings-ebs.html#cfn-ec2-spotfleet-ebsblockdevice-volumetype
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

        public class SpotFleetMonitoring
        {
            /// <summary>
            /// Enabled
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-monitoring.html#cfn-ec2-spotfleet-spotfleetmonitoring-enabled
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? Enabled
            {
                get;
                set;
            }
        }

        public class BlockDeviceMapping
        {
            /// <summary>
            /// DeviceName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-devicename
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-ebs
            /// Required: False
            /// UpdateType: Mutable
            /// Type: EbsBlockDevice
            /// </summary>
            public EbsBlockDevice Ebs
            {
                get;
                set;
            }

            /// <summary>
            /// NoDevice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-nodevice
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic NoDevice
            {
                get;
                set;
            }

            /// <summary>
            /// VirtualName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-spotfleet-spotfleetrequestconfigdata-launchspecifications-blockdevicemappings.html#cfn-ec2-spotfleet-blockdevicemapping-virtualname
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
    }
}