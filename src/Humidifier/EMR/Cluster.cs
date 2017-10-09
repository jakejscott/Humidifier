namespace Humidifier.EMR
{
    using System.Collections.Generic;
    using ClusterPropertyTypes;

    public class Cluster : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string MasterPublicDNS =  "MasterPublicDNS" ;
        }

        /// <summary>
        /// AdditionalInfo
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-additionalinfo
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AdditionalInfo
        {
            get;
            set;
        }

        /// <summary>
        /// Applications
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-applications
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: Application
        /// </summary>
        public List<Application> Applications
        {
            get;
            set;
        }

        /// <summary>
        /// AutoScalingRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-elasticmapreduce-cluster-autoscalingrole
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AutoScalingRole
        {
            get;
            set;
        }

        /// <summary>
        /// BootstrapActions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-bootstrapactions
        /// Required: False
        /// UpdateType: Immutable
        /// Type: List
        /// ItemType: BootstrapActionConfig
        /// </summary>
        public List<BootstrapActionConfig> BootstrapActions
        {
            get;
            set;
        }

        /// <summary>
        /// Configurations
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-configurations
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
        /// Instances
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-instances
        /// Required: True
        /// UpdateType: Conditional
        /// Type: JobFlowInstancesConfig
        /// </summary>
        public JobFlowInstancesConfig Instances
        {
            get;
            set;
        }

        /// <summary>
        /// JobFlowRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-jobflowrole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobFlowRole
        {
            get;
            set;
        }

        /// <summary>
        /// LogUri
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-loguri
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogUri
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// ReleaseLabel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-releaselabel
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ReleaseLabel
        {
            get;
            set;
        }

        /// <summary>
        /// ScaleDownBehavior
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-elasticmapreduce-cluster-scaledownbehavior
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScaleDownBehavior
        {
            get;
            set;
        }

        /// <summary>
        /// SecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-securityconfiguration
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecurityConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// ServiceRole
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-servicerole
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceRole
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-elasticmapreduce-cluster-tags
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
        /// VisibleToAllUsers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-cluster.html#cfn-emr-cluster-visibletoallusers
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic VisibleToAllUsers
        {
            get;
            set;
        }
    }

    namespace ClusterPropertyTypes
    {
        public class InstanceGroupConfig
        {
            /// <summary>
            /// AutoScalingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-elasticmapreduce-cluster-instancegroupconfig-autoscalingpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: AutoScalingPolicy
            /// </summary>
            public AutoScalingPolicy AutoScalingPolicy
            {
                get;
                set;
            }

            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-bidprice
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
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-configurations
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfigConfigurations-ebsconfiguration
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
            /// InstanceCount
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-instancecount
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic InstanceCount
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-instancetype
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
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-market
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Market
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-instancegroupconfig.html#cfn-emr-cluster-jobflowinstancesconfig-instancegroupconfig-name
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class SpotProvisioningSpecification
        {
            /// <summary>
            /// BlockDurationMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-blockdurationminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic BlockDurationMinutes
            {
                get;
                set;
            }

            /// <summary>
            /// TimeoutAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutaction
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-spotprovisioningspecification.html#cfn-elasticmapreduce-cluster-spotprovisioningspecification-timeoutdurationminutes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TimeoutDurationMinutes
            {
                get;
                set;
            }
        }

        public class BootstrapActionConfig
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig.html#cfn-emr-cluster-bootstrapactionconfig-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// ScriptBootstrapAction
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig.html#cfn-emr-cluster-bootstrapactionconfig-scriptbootstrapaction
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScriptBootstrapActionConfig
            /// </summary>
            public ScriptBootstrapActionConfig ScriptBootstrapAction
            {
                get;
                set;
            }
        }

        public class ScalingConstraints
        {
            /// <summary>
            /// MaxCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-elasticmapreduce-cluster-scalingconstraints-maxcapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MaxCapacity
            {
                get;
                set;
            }

            /// <summary>
            /// MinCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingconstraints.html#cfn-elasticmapreduce-cluster-scalingconstraints-mincapacity
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MinCapacity
            {
                get;
                set;
            }
        }

        public class InstanceFleetConfig
        {
            /// <summary>
            /// InstanceTypeConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-instancetypeconfigs
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-launchspecifications
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-name
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetondemandcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetOnDemandCapacity
            {
                get;
                set;
            }

            /// <summary>
            /// TargetSpotCapacity
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetconfig.html#cfn-elasticmapreduce-cluster-instancefleetconfig-targetspotcapacity
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic TargetSpotCapacity
            {
                get;
                set;
            }
        }

        public class JobFlowInstancesConfig
        {
            /// <summary>
            /// AdditionalMasterSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-additionalmastersecuritygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdditionalMasterSecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// AdditionalSlaveSecurityGroups
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-additionalslavesecuritygroups
            /// Required: False
            /// UpdateType: Immutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic AdditionalSlaveSecurityGroups
            {
                get;
                set;
            }

            /// <summary>
            /// CoreInstanceFleet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-coreinstancefleet
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceFleetConfig
            /// </summary>
            public InstanceFleetConfig CoreInstanceFleet
            {
                get;
                set;
            }

            /// <summary>
            /// CoreInstanceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-coreinstancegroup
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceGroupConfig
            /// </summary>
            public InstanceGroupConfig CoreInstanceGroup
            {
                get;
                set;
            }

            /// <summary>
            /// Ec2KeyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-ec2keyname
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ec2KeyName
            {
                get;
                set;
            }

            /// <summary>
            /// Ec2SubnetId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-ec2subnetid
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Ec2SubnetId
            {
                get;
                set;
            }

            /// <summary>
            /// EmrManagedMasterSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-emrmanagedmastersecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmrManagedMasterSecurityGroup
            {
                get;
                set;
            }

            /// <summary>
            /// EmrManagedSlaveSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-emrmanagedslavesecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic EmrManagedSlaveSecurityGroup
            {
                get;
                set;
            }

            /// <summary>
            /// HadoopVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-hadoopversion
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HadoopVersion
            {
                get;
                set;
            }

            /// <summary>
            /// MasterInstanceFleet
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-elasticmapreduce-cluster-jobflowinstancesconfig-masterinstancefleet
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceFleetConfig
            /// </summary>
            public InstanceFleetConfig MasterInstanceFleet
            {
                get;
                set;
            }

            /// <summary>
            /// MasterInstanceGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-coreinstancegroup
            /// Required: False
            /// UpdateType: Immutable
            /// Type: InstanceGroupConfig
            /// </summary>
            public InstanceGroupConfig MasterInstanceGroup
            {
                get;
                set;
            }

            /// <summary>
            /// Placement
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-placement
            /// Required: False
            /// UpdateType: Immutable
            /// Type: PlacementType
            /// </summary>
            public PlacementType Placement
            {
                get;
                set;
            }

            /// <summary>
            /// ServiceAccessSecurityGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-serviceaccesssecuritygroup
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ServiceAccessSecurityGroup
            {
                get;
                set;
            }

            /// <summary>
            /// TerminationProtected
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig.html#cfn-emr-cluster-jobflowinstancesconfig-terminationprotected
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic TerminationProtected
            {
                get;
                set;
            }
        }

        public class ScalingAction
        {
            /// <summary>
            /// Market
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-market
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Market
            {
                get;
                set;
            }

            /// <summary>
            /// SimpleScalingPolicyConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingaction.html#cfn-elasticmapreduce-cluster-scalingaction-simplescalingpolicyconfiguration
            /// Required: True
            /// UpdateType: Mutable
            /// Type: SimpleScalingPolicyConfiguration
            /// </summary>
            public SimpleScalingPolicyConfiguration SimpleScalingPolicyConfiguration
            {
                get;
                set;
            }
        }

        public class SimpleScalingPolicyConfiguration
        {
            /// <summary>
            /// AdjustmentType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-adjustmenttype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdjustmentType
            {
                get;
                set;
            }

            /// <summary>
            /// CoolDown
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-cooldown
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic CoolDown
            {
                get;
                set;
            }

            /// <summary>
            /// ScalingAdjustment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-simplescalingpolicyconfiguration.html#cfn-elasticmapreduce-cluster-simplescalingpolicyconfiguration-scalingadjustment
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ScalingAdjustment
            {
                get;
                set;
            }
        }

        public class Application
        {
            /// <summary>
            /// AdditionalInfo
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-application.html#cfn-emr-cluster-application-additionalinfo
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Map
            /// PrimitiveItemType: String
            /// </summary>
            public Dictionary<string, dynamic> AdditionalInfo
            {
                get;
                set;
            }

            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-application.html#cfn-emr-cluster-application-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Args
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-application.html#cfn-emr-cluster-application-name
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
            /// Version
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-application.html#cfn-emr-cluster-application-version
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Version
            {
                get;
                set;
            }
        }

        public class EbsBlockDeviceConfig
        {
            /// <summary>
            /// VolumeSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VolumeSpecification
            /// </summary>
            public VolumeSpecification VolumeSpecification
            {
                get;
                set;
            }

            /// <summary>
            /// VolumesPerInstance
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumesperinstance
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic VolumesPerInstance
            {
                get;
                set;
            }
        }

        public class PlacementType
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-jobflowinstancesconfig-placementtype.html#aws-properties-emr-cluster-jobflowinstancesconfig-placementtype
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AvailabilityZone
            {
                get;
                set;
            }
        }

        public class Configuration
        {
            /// <summary>
            /// Classification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-classification
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Classification
            {
                get;
                set;
            }

            /// <summary>
            /// ConfigurationProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-configurationproperties
            /// Required: False
            /// UpdateType: Mutable
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-configuration.html#cfn-emr-cluster-configuration-configurations
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Configuration
            /// </summary>
            public List<Configuration> Configurations
            {
                get;
                set;
            }
        }

        public class ScriptBootstrapActionConfig
        {
            /// <summary>
            /// Args
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig-scriptbootstrapactionconfig.html#cfn-emr-cluster-bootstrapactionconfig-scriptbootstrapaction-args
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Args
            {
                get;
                set;
            }

            /// <summary>
            /// Path
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-cluster-bootstrapactionconfig-scriptbootstrapactionconfig.html#cfn-emr-cluster-bootstrapactionconfig-scriptbootstrapaction-path
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Path
            {
                get;
                set;
            }
        }

        public class CloudWatchAlarmDefinition
        {
            /// <summary>
            /// ComparisonOperator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-comparisonoperator
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComparisonOperator
            {
                get;
                set;
            }

            /// <summary>
            /// Dimensions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-dimensions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MetricDimension
            /// </summary>
            public List<MetricDimension> Dimensions
            {
                get;
                set;
            }

            /// <summary>
            /// EvaluationPeriods
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-evaluationperiods
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic EvaluationPeriods
            {
                get;
                set;
            }

            /// <summary>
            /// MetricName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-metricname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MetricName
            {
                get;
                set;
            }

            /// <summary>
            /// Namespace
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-namespace
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Namespace
            {
                get;
                set;
            }

            /// <summary>
            /// Period
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-period
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Period
            {
                get;
                set;
            }

            /// <summary>
            /// Statistic
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-statistic
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Statistic
            {
                get;
                set;
            }

            /// <summary>
            /// Threshold
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-threshold
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic Threshold
            {
                get;
                set;
            }

            /// <summary>
            /// Unit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-cloudwatchalarmdefinition.html#cfn-elasticmapreduce-cluster-cloudwatchalarmdefinition-unit
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Unit
            {
                get;
                set;
            }
        }

        public class EbsConfiguration
        {
            /// <summary>
            /// EbsBlockDeviceConfigs
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfigs
            /// Required: False
            /// UpdateType: Mutable
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration.html#cfn-emr-ebsconfiguration-ebsoptimized
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic EbsOptimized
            {
                get;
                set;
            }
        }

        public class ScalingRule
        {
            /// <summary>
            /// Action
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-action
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingAction
            /// </summary>
            public ScalingAction Action
            {
                get;
                set;
            }

            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-description
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
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// Trigger
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingrule.html#cfn-elasticmapreduce-cluster-scalingrule-trigger
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingTrigger
            /// </summary>
            public ScalingTrigger Trigger
            {
                get;
                set;
            }
        }

        public class InstanceTypeConfig
        {
            /// <summary>
            /// BidPrice
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-bidprice
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-bidpriceaspercentageofondemandprice
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Double
            /// </summary>
            public dynamic BidPriceAsPercentageOfOnDemandPrice
            {
                get;
                set;
            }

            /// <summary>
            /// Configurations
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-configurations
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-ebsconfiguration
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-instancetype
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
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancetypeconfig.html#cfn-elasticmapreduce-cluster-instancetypeconfig-weightedcapacity
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic WeightedCapacity
            {
                get;
                set;
            }
        }

        public class MetricDimension
        {
            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-metricdimension.html#cfn-elasticmapreduce-cluster-metricdimension-key
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-metricdimension.html#cfn-elasticmapreduce-cluster-metricdimension-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }

        public class VolumeSpecification
        {
            /// <summary>
            /// Iops
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-iops
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
            /// SizeInGB
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-sizeingb
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SizeInGB
            {
                get;
                set;
            }

            /// <summary>
            /// VolumeType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification.html#cfn-emr-ebsconfiguration-ebsblockdeviceconfig-volumespecification-volumetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VolumeType
            {
                get;
                set;
            }
        }

        public class AutoScalingPolicy
        {
            /// <summary>
            /// Constraints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-elasticmapreduce-cluster-autoscalingpolicy-constraints
            /// Required: True
            /// UpdateType: Mutable
            /// Type: ScalingConstraints
            /// </summary>
            public ScalingConstraints Constraints
            {
                get;
                set;
            }

            /// <summary>
            /// Rules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-autoscalingpolicy.html#cfn-elasticmapreduce-cluster-autoscalingpolicy-rules
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ScalingRule
            /// </summary>
            public List<ScalingRule> Rules
            {
                get;
                set;
            }
        }

        public class InstanceFleetProvisioningSpecifications
        {
            /// <summary>
            /// SpotSpecification
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-instancefleetprovisioningspecifications.html#cfn-elasticmapreduce-cluster-instancefleetprovisioningspecifications-spotspecification
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

        public class ScalingTrigger
        {
            /// <summary>
            /// CloudWatchAlarmDefinition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-elasticmapreduce-cluster-scalingtrigger.html#cfn-elasticmapreduce-cluster-scalingtrigger-cloudwatchalarmdefinition
            /// Required: True
            /// UpdateType: Mutable
            /// Type: CloudWatchAlarmDefinition
            /// </summary>
            public CloudWatchAlarmDefinition CloudWatchAlarmDefinition
            {
                get;
                set;
            }
        }
    }
}