namespace Humidifier.WorkSpaces
{
    using System.Collections.Generic;
    using WorkspaceTypes;

    public class Workspace : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::WorkSpaces::Workspace";
            }
        }

        /// <summary>
        /// BundleId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-bundleid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic BundleId
        {
            get;
            set;
        }

        /// <summary>
        /// DirectoryId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-directoryid
        /// Required: True
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic DirectoryId
        {
            get;
            set;
        }

        /// <summary>
        /// RootVolumeEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-rootvolumeencryptionenabled
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic RootVolumeEncryptionEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-tags
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
        /// UserName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-username
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserName
        {
            get;
            set;
        }

        /// <summary>
        /// UserVolumeEncryptionEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-uservolumeencryptionenabled
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic UserVolumeEncryptionEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// VolumeEncryptionKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-volumeencryptionkey
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic VolumeEncryptionKey
        {
            get;
            set;
        }

        /// <summary>
        /// WorkspaceProperties
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-workspaces-workspace.html#cfn-workspaces-workspace-workspaceproperties
        /// Required: False
        /// UpdateType: Mutable
        /// Type: WorkspaceProperties
        /// </summary>
        public WorkspaceProperties WorkspaceProperties
        {
            get;
            set;
        }
    }

    namespace WorkspaceTypes
    {
        public class WorkspaceProperties
        {
            /// <summary>
            /// ComputeTypeName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-computetypename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComputeTypeName
            {
                get;
                set;
            }

            /// <summary>
            /// RootVolumeSizeGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-rootvolumesizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RootVolumeSizeGib
            {
                get;
                set;
            }

            /// <summary>
            /// RunningMode
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-runningmode
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RunningMode
            {
                get;
                set;
            }

            /// <summary>
            /// RunningModeAutoStopTimeoutInMinutes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-runningmodeautostoptimeoutinminutes
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic RunningModeAutoStopTimeoutInMinutes
            {
                get;
                set;
            }

            /// <summary>
            /// UserVolumeSizeGib
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-workspaces-workspace-workspaceproperties.html#cfn-workspaces-workspace-workspaceproperties-uservolumesizegib
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic UserVolumeSizeGib
            {
                get;
                set;
            }
        }
    }
}