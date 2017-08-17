namespace Humidifier.EMR
{
    using System.Collections.Generic;
    using InstanceFleetConfigPropertyTypes;

    public class InstanceFleetConfig : Humidifier.Resource
    {
        /// <summary>
        /// ClusterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-clusterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ClusterId
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceFleetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancefleettype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceFleetType
        {
            get;
            set;
        }

        /// <summary>
        /// InstanceTypeConfigs
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfigs
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: InstanceTypeConfig
        /// </summary>
        public List<InstanceTypeConfig> InstanceTypeConfigs
        {
            get;
            set;
        }

        /// <summary>
        /// LaunchSpecifications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-launchspecifications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: InstanceFleetProvisioningSpecifications
        /// </summary>
        public InstanceFleetProvisioningSpecifications LaunchSpecifications
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// TargetOnDemandCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetondemandcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? TargetOnDemandCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// TargetSpotCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-elasticmapreduce-instancefleetconfig.html#cfn-elasticmapreduce-instancefleetconfig-targetspotcapacity
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? TargetSpotCapacity
        {
            get;
            set;
        }
    }

    namespace InstanceFleetConfigPropertyTypes
    {
        public class InstanceTypeConfig
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-bidprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BidPrice
            {
                get;
                set;
            }

            /// <summary>
            /// BidPriceAsPercentageOfOnDemandPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public double ? BidPriceAsPercentageOfOnDemandPrice
            {
                get;
                set;
            }

            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Configuration> Configurations
            {
                get;
                set;
            }

            /// <summary>
            /// EbsConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-ebsconfiguration
            /// Required: False
            /// UpdateType: Immutable
            /// Type: EbsConfiguration
            /// </summary>
            public EbsConfiguration EbsConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-instancetype
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
            /// WeightedCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancetypeconfig.html#cfn-elasticmapreduce-instancefleetconfig-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? WeightedCapacity
            {
                get;
                set;
            }
        }

        public class VolumeSpecification
        {
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-iops
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? Iops
            {
                get;
                set;
            }

            /// <summary>
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public int SizeInGB
            {
                get;
                set;
            }

            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-volumespecification.html#cfn-elasticmapreduce-instancefleetconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType
            {
                get;
                set;
            }
        }

        public class SpotProvisioningSpecification
        {
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? BlockDurationMinutes
            {
                get;
                set;
            }

            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-timeoutaction
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TimeoutAction
            {
                get;
                set;
            }

            /// <summary>
            /// TimeoutDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-spotprovisioningspecification.html#cfn-elasticmapreduce-instancefleetconfig-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public int TimeoutDurationMinutes
            {
                get;
                set;
            }
        }

        public class Configuration
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-classification
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification
            {
                get;
                set;
            }

            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-configurationproperties
            /// Required: False
            /// UpdateType: Immutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> ConfigurationProperties
            {
                get;
                set;
            }

            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-configuration.html#cfn-elasticmapreduce-instancefleetconfig-configuration-configurations
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Configuration> Configurations
            {
                get;
                set;
            }
        }

        public class EbsConfiguration
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html#cfn-elasticmapreduce-instancefleetconfig-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// ItemType: EbsBlockDeviceConfig
            /// </summary>
            public List<EbsBlockDeviceConfig> EbsBlockDeviceConfigs
            {
                get;
                set;
            }

            /// <summary>
            /// EbsOptimized
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsconfiguration.html#cfn-elasticmapreduce-instancefleetconfig-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Boolean
            /// </summary>
            public bool ? EbsOptimized
            {
                get;
                set;
            }
        }

        public class InstanceFleetProvisioningSpecifications
        {
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-instancefleetconfig-instancefleetprovisioningspecifications-spotspecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SpotProvisioningSpecification
            /// </summary>
            public SpotProvisioningSpecification SpotSpecification
            {
                get;
                set;
            }
        }

        public class EbsBlockDeviceConfig
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html#cfn-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Immutable
            /// Type: VolumeSpecification
            /// </summary>
            public VolumeSpecification VolumeSpecification
            {
                get;
                set;
            }

            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig.html#cfn-elasticmapreduce-instancefleetconfig-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public int ? VolumesPerInstance
            {
                get;
                set;
            }
        }
    }
}