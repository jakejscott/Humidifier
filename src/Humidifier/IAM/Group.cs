namespace Humidifier.IAM
{
    using System.Collections.Generic;
    using GroupPropertyTypes;

    public class Group : Humidifier.Resource
    {
        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html#cfn-iam-group-groupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupName
        {
            get;
            set;
        }

        /// <summary>
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html#cfn-iam-group-managepolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> ManagedPolicyArns
        {
            get;
            set;
        }

        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html#cfn-iam-group-path
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Path
        {
            get;
            set;
        }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-group.html#cfn-iam-group-policies
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Policy
        /// </summary>
        public List<Policy> Policies
        {
            get;
            set;
        }
    }

    namespace GroupPropertyTypes
    {
        public class Policy
        {
            /// <summary>
            /// PolicyDocument
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policydocument
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Json
            /// </summary>
            public dynamic PolicyDocument
            {
                get;
                set;
            }

            /// <summary>
            /// PolicyName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-iam-policy.html#cfn-iam-policies-policyname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic PolicyName
            {
                get;
                set;
            }
        }
    }
}