namespace Humidifier.ECR
{
    using System.Collections.Generic;
    using RepositoryTypes;

    public class Repository : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        /// <summary>
        /// LifecyclePolicy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-lifecyclepolicy
        /// Required: False
        /// UpdateType: Mutable
        /// Type: LifecyclePolicy
        /// </summary>
        public LifecyclePolicy LifecyclePolicy
        {
            get;
            set;
        }

        /// <summary>
        /// RepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositoryname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RepositoryName
        {
            get;
            set;
        }

        /// <summary>
        /// RepositoryPolicyText
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ecr-repository.html#cfn-ecr-repository-repositorypolicytext
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic RepositoryPolicyText
        {
            get;
            set;
        }
    }

    namespace RepositoryTypes
    {
        public class LifecyclePolicy
        {
            /// <summary>
            /// LifecyclePolicyText
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-lifecyclepolicytext
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic LifecyclePolicyText
            {
                get;
                set;
            }

            /// <summary>
            /// RegistryId
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ecr-repository-lifecyclepolicy.html#cfn-ecr-repository-lifecyclepolicy-registryid
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RegistryId
            {
                get;
                set;
            }
        }
    }
}