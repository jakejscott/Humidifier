namespace Humidifier.ManagedBlockchain
{
    using System.Collections.Generic;
    using NodeTypes;

    public class Node : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string MemberId =  "MemberId" ;
            public static string NodeId =  "NodeId" ;
            public static string Arn =  "Arn" ;
            public static string NetworkId =  "NetworkId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ManagedBlockchain::Node";
            }
        }

        /// <summary>
        /// MemberId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-node.html#cfn-managedblockchain-node-memberid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic MemberId
        {
            get;
            set;
        }

        /// <summary>
        /// NetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-node.html#cfn-managedblockchain-node-networkid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkId
        {
            get;
            set;
        }

        /// <summary>
        /// NodeConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-node.html#cfn-managedblockchain-node-nodeconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: NodeConfiguration
        /// </summary>
        public NodeConfiguration NodeConfiguration
        {
            get;
            set;
        }
    }

    namespace NodeTypes
    {
        public class NodeConfiguration
        {
            /// <summary>
            /// AvailabilityZone
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-node-nodeconfiguration.html#cfn-managedblockchain-node-nodeconfiguration-availabilityzone
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
            /// InstanceType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-node-nodeconfiguration.html#cfn-managedblockchain-node-nodeconfiguration-instancetype
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic InstanceType
            {
                get;
                set;
            }
        }
    }
}