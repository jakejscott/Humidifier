namespace Humidifier.Batch
{
    using System.Collections.Generic;
    using JobDefinitionPropertyTypes;

    public class JobDefinition : Humidifier.Resource
    {
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
        /// ContainerProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-batch-jobdefinition.html#cfn-batch-jobdefinition-containerproperties
        /// Required: True
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

    namespace JobDefinitionPropertyTypes
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

        public class ContainerProperties
        {
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
    }
}