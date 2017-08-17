namespace Humidifier.WAFRegional
{
    using System.Collections.Generic;
    using ByteMatchSetPropertyTypes;

    public class ByteMatchSet : Humidifier.Resource
    {
        /// <summary>
        /// ByteMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-bytematchset.html#cfn-wafregional-bytematchset-bytematchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: ByteMatchTuple
        /// </summary>
        public List<ByteMatchTuple> ByteMatchTuples
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-wafregional-bytematchset.html#cfn-wafregional-bytematchset-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace ByteMatchSetPropertyTypes
    {
        public class ByteMatchTuple
        {
            /// <summary>
            /// TargetString
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstring
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetString
            {
                get;
                set;
            }

            /// <summary>
            /// TargetStringBase64
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-targetstringbase64
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TargetStringBase64
            {
                get;
                set;
            }

            /// <summary>
            /// PositionalConstraint
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-positionalconstraint
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PositionalConstraint
            {
                get;
                set;
            }

            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextTransformation
            {
                get;
                set;
            }

            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-bytematchtuple.html#cfn-wafregional-bytematchset-bytematchtuple-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch
            {
                get;
                set;
            }
        }

        public class FieldToMatch
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-type
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
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-wafregional-bytematchset-fieldtomatch.html#cfn-wafregional-bytematchset-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data
            {
                get;
                set;
            }
        }
    }
}