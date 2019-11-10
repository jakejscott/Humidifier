namespace Humidifier.PinpointEmail
{
    using System.Collections.Generic;
    using IdentityTypes;

    public class Identity : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string IdentityDNSRecordName3 =  "IdentityDNSRecordName3" ;
            public static string IdentityDNSRecordName1 =  "IdentityDNSRecordName1" ;
            public static string IdentityDNSRecordName2 =  "IdentityDNSRecordName2" ;
            public static string IdentityDNSRecordValue3 =  "IdentityDNSRecordValue3" ;
            public static string IdentityDNSRecordValue2 =  "IdentityDNSRecordValue2" ;
            public static string IdentityDNSRecordValue1 =  "IdentityDNSRecordValue1" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::PinpointEmail::Identity";
            }
        }

        /// <summary>
        /// FeedbackForwardingEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-feedbackforwardingenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic FeedbackForwardingEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// DkimSigningEnabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-dkimsigningenabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic DkimSigningEnabled
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tags
        /// </summary>
        public List<Tags> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-name
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
        /// MailFromAttributes
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpointemail-identity.html#cfn-pinpointemail-identity-mailfromattributes
        /// Required: False
        /// UpdateType: Mutable
        /// Type: MailFromAttributes
        /// </summary>
        public MailFromAttributes MailFromAttributes
        {
            get;
            set;
        }
    }

    namespace IdentityTypes
    {
        public class Tags
        {
            /// <summary>
            /// Value
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-tags.html#cfn-pinpointemail-identity-tags-value
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Value
            {
                get;
                set;
            }

            /// <summary>
            /// Key
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-tags.html#cfn-pinpointemail-identity-tags-key
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

        public class MailFromAttributes
        {
            /// <summary>
            /// MailFromDomain
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-mailfromattributes.html#cfn-pinpointemail-identity-mailfromattributes-mailfromdomain
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic MailFromDomain
            {
                get;
                set;
            }

            /// <summary>
            /// BehaviorOnMxFailure
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-pinpointemail-identity-mailfromattributes.html#cfn-pinpointemail-identity-mailfromattributes-behavioronmxfailure
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic BehaviorOnMxFailure
            {
                get;
                set;
            }
        }
    }
}