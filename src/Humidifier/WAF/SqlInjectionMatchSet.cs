namespace Humidifier.WAF
{
    using System.Collections.Generic;
    using SqlInjectionMatchSetPropertyTypes;

    public class SqlInjectionMatchSet : Humidifier.Resource
    {
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html#cfn-waf-sqlinjectionmatchset-name
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
        /// SqlInjectionMatchTuples
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-sqlinjectionmatchset.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: SqlInjectionMatchTuple
        /// </summary>
        public List<SqlInjectionMatchTuple> SqlInjectionMatchTuples
        {
            get;
            set;
        }
    }

    namespace SqlInjectionMatchSetPropertyTypes
    {
        public class SqlInjectionMatchTuple
        {
            /// <summary>
            /// FieldToMatch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sqlinjectionmatchset-sqlinjectionmatchtuples.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples-fieldtomatch
            /// Required: True
            /// UpdateType: Mutable
            /// Type: FieldToMatch
            /// </summary>
            public FieldToMatch FieldToMatch
            {
                get;
                set;
            }

            /// <summary>
            /// TextTransformation
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-sqlinjectionmatchset-sqlinjectionmatchtuples.html#cfn-waf-sqlinjectionmatchset-sqlinjectionmatchtuples-texttransformation
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic TextTransformation
            {
                get;
                set;
            }
        }

        public class FieldToMatch
        {
            /// <summary>
            /// Data
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-data
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Data
            {
                get;
                set;
            }

            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-bytematchset-bytematchtuples-fieldtomatch.html#cfn-waf-sizeconstraintset-sizeconstraint-fieldtomatch-type
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Type
            {
                get;
                set;
            }
        }
    }
}