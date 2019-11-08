namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using JobDefinitionTypes;

    public class JobDefinition : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Batch::JobDefinition";
            }
        }

        /// <summary>
        /// Type
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-type
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Type
        {
            get;
            set;
        }

        /// <summary>
        /// Parameters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-parameters
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Parameters
        {
            get;
            set;
        }

        /// <summary>
        /// NodeProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-nodeproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NodeProperties
        /// </summary>
        public NodeProperties NodeProperties
        {
            get;
            set;
        }

        /// <summary>
        /// Timeout
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-timeout
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Timeout
        /// </summary>
        public Timeout Timeout
        {
            get;
            set;
        }

        /// <summary>
        /// ContainerProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-containerproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: ContainerProperties
        /// </summary>
        public ContainerProperties ContainerProperties
        {
            get;
            set;
        }

        /// <summary>
        /// JobDefinitionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-jobdefinitionname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic JobDefinitionName
        {
            get;
            set;
        }

        /// <summary>
        /// RetryStrategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-retrystrategy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RetryStrategy
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get;
            set;
        }
    }

    namespace JobDefinitionTypes
    {
        public class Volumes
        {
            /// <summary>
            /// Host
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html#cfn-batch-jobdefinition-volumes-host
            /// Required: False
            /// UpdateType: Mutable
            /// Type: VolumesHost
            /// </summary>
            public VolumesHost Host
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumes.html#cfn-batch-jobdefinition-volumes-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class ContainerProperties
        {
            /// <summary>
            /// User
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-user
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic User
            {
                get;
                set;
            }

            /// <summary>
            /// Memory
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-memory
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Memory
            {
                get;
                set;
            }

            /// <summary>
            /// Privileged
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-privileged
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic Privileged
            {
                get;
                set;
            }

            /// <summary>
            /// LinuxParameters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-linuxparameters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: LinuxParameters
            /// </summary>
            public LinuxParameters LinuxParameters
            {
                get;
                set;
            }

            /// <summary>
            /// JobRoleArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-jobrolearn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic JobRoleArn
            {
                get;
                set;
            }

            /// <summary>
            /// ReadonlyRootFilesystem
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-readonlyrootfilesystem
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadonlyRootFilesystem
            {
                get;
                set;
            }

            /// <summary>
            /// Vcpus
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-vcpus
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Vcpus
            {
                get;
                set;
            }

            /// <summary>
            /// Image
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-image
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Image
            {
                get;
                set;
            }

            /// <summary>
            /// ResourceRequirements
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-resourcerequirements
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: ResourceRequirement
            /// </summary>
            public List<ResourceRequirement> ResourceRequirements
            {
                get;
                set;
            }

            /// <summary>
            /// MountPoints
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-mountpoints
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: MountPoints
            /// </summary>
            public List<MountPoints> MountPoints
            {
                get;
                set;
            }

            /// <summary>
            /// Volumes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-volumes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Volumes
            /// </summary>
            public List<Volumes> Volumes
            {
                get;
                set;
            }

            /// <summary>
            /// Command
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-command
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Command
            {
                get;
                set;
            }

            /// <summary>
            /// Environment
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-environment
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Environment
            /// </summary>
            public List<Environment> Environment
            {
                get;
                set;
            }

            /// <summary>
            /// Ulimits
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-ulimits
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Ulimit
            /// </summary>
            public List<Ulimit> Ulimits
            {
                get;
                set;
            }

            /// <summary>
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties.html#cfn-batch-jobdefinition-containerproperties-instancetype
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType
            {
                get;
                set;
            }
        }

        public class ResourceRequirement
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-resourcerequirement.html#cfn-batch-jobdefinition-resourcerequirement-type
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }

            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-resourcerequirement.html#cfn-batch-jobdefinition-resourcerequirement-value
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

        public class MountPoints
        {
            /// <summary>
            /// ReadOnly
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-readonly
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic ReadOnly
            {
                get;
                set;
            }

            /// <summary>
            /// SourceVolume
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-sourcevolume
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourceVolume
            {
                get;
                set;
            }

            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-mountpoints.html#cfn-batch-jobdefinition-mountpoints-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath
            {
                get;
                set;
            }
        }

        public class Environment
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-environment.html#cfn-batch-jobdefinition-environment-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-environment.html#cfn-batch-jobdefinition-environment-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class Ulimit
        {
            /// <summary>
            /// SoftLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-softlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic SoftLimit
            {
                get;
                set;
            }

            /// <summary>
            /// HardLimit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-hardlimit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic HardLimit
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-ulimit.html#cfn-batch-jobdefinition-ulimit-name
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class VolumesHost
        {
            /// <summary>
            /// SourcePath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-volumeshost.html#cfn-batch-jobdefinition-volumeshost-sourcepath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SourcePath
            {
                get;
                set;
            }
        }

        public class LinuxParameters
        {
            /// <summary>
            /// Devices
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-containerproperties-linuxparameters.html#cfn-batch-jobdefinition-containerproperties-linuxparameters-devices
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Device
            /// </summary>
            public List<Device> Devices
            {
                get;
                set;
            }
        }

        public class NodeProperties
        {
            /// <summary>
            /// MainNode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-mainnode
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic MainNode
            {
                get;
                set;
            }

            /// <summary>
            /// NodeRangeProperties
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-noderangeproperties
            /// Required: True
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: NodeRangeProperty
            /// </summary>
            public List<NodeRangeProperty> NodeRangeProperties
            {
                get;
                set;
            }

            /// <summary>
            /// NumNodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-nodeproperties.html#cfn-batch-jobdefinition-nodeproperties-numnodes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic NumNodes
            {
                get;
                set;
            }
        }

        public class RetryStrategy
        {
            /// <summary>
            /// Attempts
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-retrystrategy.html#cfn-batch-jobdefinition-retrystrategy-attempts
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Attempts
            {
                get;
                set;
            }
        }

        public class Timeout
        {
            /// <summary>
            /// AttemptDurationSeconds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-timeout.html#cfn-batch-jobdefinition-timeout-attemptdurationseconds
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AttemptDurationSeconds
            {
                get;
                set;
            }
        }

        public class NodeRangeProperty
        {
            /// <summary>
            /// Container
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-container
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ContainerProperties
            /// </summary>
            public ContainerProperties Container
            {
                get;
                set;
            }

            /// <summary>
            /// TargetNodes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-noderangeproperty.html#cfn-batch-jobdefinition-noderangeproperty-targetnodes
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetNodes
            {
                get;
                set;
            }
        }

        public class Device
        {
            /// <summary>
            /// HostPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-hostpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic HostPath
            {
                get;
                set;
            }

            /// <summary>
            /// Permissions
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-permissions
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Permissions
            {
                get;
                set;
            }

            /// <summary>
            /// ContainerPath
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-batch-jobdefinition-device.html#cfn-batch-jobdefinition-device-containerpath
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ContainerPath
            {
                get;
                set;
            }
        }
    }
}