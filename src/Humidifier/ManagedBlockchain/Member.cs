namespace Humidifier.ManagedBlockchain
{
    using System.Collections.Generic;
    using MemberTypes;

    public class Member : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string MemberId =  "MemberId" ;
            public static string NetworkId =  "NetworkId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::ManagedBlockchain::Member";
            }
        }

        /// <summary>
        /// MemberConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-memberconfiguration
        /// Required: True
        /// UpdateType: Mutable
        /// Type: MemberConfiguration
        /// </summary>
        public MemberConfiguration MemberConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// NetworkConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-networkconfiguration
        /// Required: False
        /// UpdateType: Mutable
        /// Type: NetworkConfiguration
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get;
            set;
        }

        /// <summary>
        /// NetworkId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-networkid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic NetworkId
        {
            get;
            set;
        }

        /// <summary>
        /// InvitationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-managedblockchain-member.html#cfn-managedblockchain-member-invitationid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InvitationId
        {
            get;
            set;
        }
    }

    namespace MemberTypes
    {
        public class MemberConfiguration
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-description
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
            /// MemberFrameworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-memberframeworkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemberFrameworkConfiguration
            /// </summary>
            public MemberFrameworkConfiguration MemberFrameworkConfiguration
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberconfiguration.html#cfn-managedblockchain-member-memberconfiguration-name
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

        public class ApprovalThresholdPolicy
        {
            /// <summary>
            /// ThresholdComparator
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdcomparator
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ThresholdComparator
            {
                get;
                set;
            }

            /// <summary>
            /// ThresholdPercentage
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-thresholdpercentage
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ThresholdPercentage
            {
                get;
                set;
            }

            /// <summary>
            /// ProposalDurationInHours
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-approvalthresholdpolicy.html#cfn-managedblockchain-member-approvalthresholdpolicy-proposaldurationinhours
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ProposalDurationInHours
            {
                get;
                set;
            }
        }

        public class NetworkFrameworkConfiguration
        {
            /// <summary>
            /// NetworkFabricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkframeworkconfiguration.html#cfn-managedblockchain-member-networkframeworkconfiguration-networkfabricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkFabricConfiguration
            /// </summary>
            public NetworkFabricConfiguration NetworkFabricConfiguration
            {
                get;
                set;
            }
        }

        public class NetworkConfiguration
        {
            /// <summary>
            /// Description
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-description
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
            /// FrameworkVersion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-frameworkversion
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic FrameworkVersion
            {
                get;
                set;
            }

            /// <summary>
            /// VotingPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-votingpolicy
            /// Required: True
            /// UpdateType: Mutable
            /// Type: VotingPolicy
            /// </summary>
            public VotingPolicy VotingPolicy
            {
                get;
                set;
            }

            /// <summary>
            /// Framework
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-framework
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Framework
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-name
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
            /// NetworkFrameworkConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkconfiguration.html#cfn-managedblockchain-member-networkconfiguration-networkframeworkconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: NetworkFrameworkConfiguration
            /// </summary>
            public NetworkFrameworkConfiguration NetworkFrameworkConfiguration
            {
                get;
                set;
            }
        }

        public class MemberFrameworkConfiguration
        {
            /// <summary>
            /// MemberFabricConfiguration
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberframeworkconfiguration.html#cfn-managedblockchain-member-memberframeworkconfiguration-memberfabricconfiguration
            /// Required: False
            /// UpdateType: Mutable
            /// Type: MemberFabricConfiguration
            /// </summary>
            public MemberFabricConfiguration MemberFabricConfiguration
            {
                get;
                set;
            }
        }

        public class NetworkFabricConfiguration
        {
            /// <summary>
            /// Edition
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-networkfabricconfiguration.html#cfn-managedblockchain-member-networkfabricconfiguration-edition
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Edition
            {
                get;
                set;
            }
        }

        public class VotingPolicy
        {
            /// <summary>
            /// ApprovalThresholdPolicy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-votingpolicy.html#cfn-managedblockchain-member-votingpolicy-approvalthresholdpolicy
            /// Required: False
            /// UpdateType: Mutable
            /// Type: ApprovalThresholdPolicy
            /// </summary>
            public ApprovalThresholdPolicy ApprovalThresholdPolicy
            {
                get;
                set;
            }
        }

        public class MemberFabricConfiguration
        {
            /// <summary>
            /// AdminUsername
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberfabricconfiguration.html#cfn-managedblockchain-member-memberfabricconfiguration-adminusername
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdminUsername
            {
                get;
                set;
            }

            /// <summary>
            /// AdminPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-managedblockchain-member-memberfabricconfiguration.html#cfn-managedblockchain-member-memberfabricconfiguration-adminpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AdminPassword
            {
                get;
                set;
            }
        }
    }
}