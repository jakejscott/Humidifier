namespace Humidifier.IAM
{
    using System.Collections.Generic;
    using RoleTypes;

    public class Role : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
            public static string RoleId =  "RoleId" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IAM::Role";
            }
        }

        /// <summary>
        /// AssumeRolePolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-assumerolepolicydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic AssumeRolePolicyDocument
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-description
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
        /// ManagedPolicyArns
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-managepolicyarns
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic ManagedPolicyArns
        {
            get;
            set;
        }

        /// <summary>
        /// MaxSessionDuration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-maxsessionduration
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic MaxSessionDuration
        {
            get;
            set;
        }

        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Path
        {
            get;
            set;
        }

        /// <summary>
        /// PermissionsBoundary
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-permissionsboundary
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic PermissionsBoundary
        {
            get;
            set;
        }

        /// <summary>
        /// Policies
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-policies
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

        /// <summary>
        /// RoleName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-rolename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-role.html#cfn-iam-role-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }
    }

    namespace RoleTypes
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