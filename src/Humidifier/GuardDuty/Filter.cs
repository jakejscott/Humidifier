namespace Humidifier.GuardDuty
{
    using System.Collections.Generic;
    using FilterTypes;

    public class Filter : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::GuardDuty::Filter";
            }
        }

        /// <summary>
        /// Action
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-action
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Action
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-description
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// DetectorId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-detectorid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DetectorId
        {
            get;
            set;
        }

        /// <summary>
        /// FindingCriteria
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-findingcriteria
        /// Required: True
        /// UpdateType: Mutable
        /// Type: FindingCriteria
        /// </summary>
        public FindingCriteria FindingCriteria
        {
            get;
            set;
        }

        /// <summary>
        /// Rank
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-rank
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Rank
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-guardduty-filter.html#cfn-guardduty-filter-name
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

    namespace FilterTypes
    {
        public class FindingCriteria
        {
            /// <summary>
            /// Criterion
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html#cfn-guardduty-filter-findingcriteria-criterion
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic Criterion
            {
                get;
                set;
            }

            /// <summary>
            /// ItemType
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-findingcriteria.html#cfn-guardduty-filter-findingcriteria-itemtype
            /// Required: False
            /// UpdateType: Mutable
            /// Type: Condition
            /// </summary>
            public Condition ItemType
            {
                get;
                set;
            }
        }

        public class Condition
        {
            /// <summary>
            /// Lt
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lt
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Lt
            {
                get;
                set;
            }

            /// <summary>
            /// Gte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-gte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Gte
            {
                get;
                set;
            }

            /// <summary>
            /// Neq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-neq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Neq
            {
                get;
                set;
            }

            /// <summary>
            /// Eq
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-eq
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Eq
            {
                get;
                set;
            }

            /// <summary>
            /// Lte
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-guardduty-filter-condition.html#cfn-guardduty-filter-condition-lte
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Lte
            {
                get;
                set;
            }
        }
    }
}