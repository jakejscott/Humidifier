namespace Humidifier.ECR
{
    using System.Collections.Generic;
    using RepositoryPropertyTypes;

    public class Repository : IResource
    {
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

    namespace RepositoryPropertyTypes
    {
    }
}