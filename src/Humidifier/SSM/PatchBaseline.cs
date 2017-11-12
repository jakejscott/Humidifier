namespace Humidifier.SSM
{
    using System.Collections.Generic;
    using PatchBaselinePropertyTypes;

    public class PatchBaseline : Humidifier.Resource
    {
        /// <summary>
        /// OperatingSystem
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-operatingsystem
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic OperatingSystem
        {
            get;
            set;
        }

        /// <summary>
        /// ApprovedPatches
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvedpatches
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ApprovedPatches
        {
            get;
            set;
        }

        /// <summary>
        /// PatchGroups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-patchgroups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PatchGroups
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-description
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
        /// ApprovedPatchesComplianceLevel
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvedpatchescompliancelevel
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApprovedPatchesComplianceLevel
        {
            get;
            set;
        }

        /// <summary>
        /// ApprovalRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-approvalrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RuleGroup
        /// </summary>
        public RuleGroup ApprovalRules
        {
            get;
            set;
        }

        /// <summary>
        /// GlobalFilters
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-globalfilters
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PatchFilterGroup
        /// </summary>
        public PatchFilterGroup GlobalFilters
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-name
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
        /// RejectedPatches
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-patchbaseline.html#cfn-ssm-patchbaseline-rejectedpatches
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic RejectedPatches
        {
            get;
            set;
        }
    }

    namespace PatchBaselinePropertyTypes
    {
        public class RuleGroup
        {
            /// <summary>
            /// PatchRules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rulegroup.html#cfn-ssm-patchbaseline-rulegroup-patchrules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Rule
            /// </summary>
            public List<Rule> PatchRules
            {
                get;
                set;
            }
        }

        public class PatchFilter
        {
            /// <summary>
            /// Values
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html#cfn-ssm-patchbaseline-patchfilter-values
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Values
            {
                get;
                set;
            }

            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfilter.html#cfn-ssm-patchbaseline-patchfilter-key
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Key
            {
                get;
                set;
            }
        }

        public class Rule
        {
            /// <summary>
            /// PatchFilterGroup
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-patchfiltergroup
            /// Required: False
            /// UpdateType: Mutable
            /// Type: PatchFilterGroup
            /// </summary>
            public PatchFilterGroup PatchFilterGroup
            {
                get;
                set;
            }

            /// <summary>
            /// ApproveAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-approveafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ApproveAfterDays
            {
                get;
                set;
            }

            /// <summary>
            /// ComplianceLevel
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-rule.html#cfn-ssm-patchbaseline-rule-compliancelevel
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic ComplianceLevel
            {
                get;
                set;
            }
        }

        public class PatchFilterGroup
        {
            /// <summary>
            /// PatchFilters
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ssm-patchbaseline-patchfiltergroup.html#cfn-ssm-patchbaseline-patchfiltergroup-patchfilters
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: PatchFilter
            /// </summary>
            public List<PatchFilter> PatchFilters
            {
                get;
                set;
            }
        }
    }
}