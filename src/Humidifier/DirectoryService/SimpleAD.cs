namespace Humidifier.DirectoryService
{
    using System.Collections.Generic;
    using SimpleADPropertyTypes;

    public class SimpleAD : Humidifier.Resource
    {
        /// <summary>
        /// CreateAlias
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-createalias
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? CreateAlias
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-description
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// EnableSso
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-enablesso
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? EnableSso
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-name
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
        /// Password
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-password
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Password
        {
            get;
            set;
        }

        /// <summary>
        /// ShortName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-shortname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ShortName
        {
            get;
            set;
        }

        /// <summary>
        /// Size
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-size
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Size
        {
            get;
            set;
        }

        /// <summary>
        /// VpcSettings
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-directoryservice-simplead.html#cfn-directoryservice-simplead-vpcsettings
        /// Required: True
        /// UpdateType: Immutable
        /// Type: VpcSettings
        /// </summary>
        public VpcSettings VpcSettings
        {
            get;
            set;
        }
    }

    namespace SimpleADPropertyTypes
    {
        public class VpcSettings
        {
            /// <summary>
            /// SubnetIds
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-simplead-vpcsettings.html#cfn-directoryservice-simplead-vpcsettings-subnetids
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
            /// VpcId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-directoryservice-simplead-vpcsettings.html#cfn-directoryservice-simplead-vpcsettings-vpcid
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic VpcId
            {
                get;
                set;
            }
        }
    }
}