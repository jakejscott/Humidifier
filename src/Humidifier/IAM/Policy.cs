namespace Humidifier.IAM
{
    using System.Collections.Generic;

    public class Policy : Humidifier.Resource
    {
        /// <summary>
        /// Groups
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html#cfn-iam-policy-groups
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Groups
        {
            get;
            set;
        }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html#cfn-iam-policy-policydocument
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
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html#cfn-iam-policy-policyname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PolicyName
        {
            get;
            set;
        }

        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html#cfn-iam-policy-roles
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Roles
        {
            get;
            set;
        }

        /// <summary>
        /// Users
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-policy.html#cfn-iam-policy-users
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Users
        {
            get;
            set;
        }
    }
}