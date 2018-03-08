namespace Humidifier.SES
{
    using System.Collections.Generic;
    using ReceiptFilterTypes;

    public class ReceiptFilter : Humidifier.Resource
    {
        /// <summary>
        /// Filter
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ses-receiptfilter.html#cfn-ses-receiptfilter-filter
        /// Required: True
        /// UpdateType: Immutable
        /// Type: Filter
        /// </summary>
        public Filter Filter
        {
            get;
            set;
        }
    }

    namespace ReceiptFilterTypes
    {
        public class Filter
        {
            /// <summary>
            /// IpFilter
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-ipfilter
            /// Required: True
            /// UpdateType: Mutable
            /// Type: IpFilter
            /// </summary>
            public IpFilter IpFilter
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-filter.html#cfn-ses-receiptfilter-filter-name
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

        public class IpFilter
        {
            /// <summary>
            /// Policy
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-policy
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Policy
            {
                get;
                set;
            }

            /// <summary>
            /// Cidr
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ses-receiptfilter-ipfilter.html#cfn-ses-receiptfilter-ipfilter-cidr
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Cidr
            {
                get;
                set;
            }
        }
    }
}