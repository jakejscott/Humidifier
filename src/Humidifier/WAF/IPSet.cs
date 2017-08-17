namespace Humidifier.WAF
{
    using System.Collections.Generic;
    using IPSetPropertyTypes;

    public class IPSet : Humidifier.Resource
    {
        /// <summary>
        /// IPSetDescriptors
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html#cfn-waf-ipset-ipsetdescriptors
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: IPSetDescriptor
        /// </summary>
        public List<IPSetDescriptor> IPSetDescriptors
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-waf-ipset.html#cfn-waf-ipset-name
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

    namespace IPSetPropertyTypes
    {
        public class IPSetDescriptor
        {
            /// <summary>
            /// Type
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html#cfn-waf-ipset-ipsetdescriptors-type
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
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-waf-ipset-ipsetdescriptors.html#cfn-waf-ipset-ipsetdescriptors-value
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }
        }
    }
}