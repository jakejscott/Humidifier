namespace Humidifier.SageMaker
{
    using System.Collections.Generic;
    using CodeRepositoryTypes;

    public class CodeRepository : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string CodeRepositoryName =  "CodeRepositoryName" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SageMaker::CodeRepository";
            }
        }

        /// <summary>
        /// CodeRepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-coderepositoryname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CodeRepositoryName
        {
            get;
            set;
        }

        /// <summary>
        /// GitConfig
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-sagemaker-coderepository.html#cfn-sagemaker-coderepository-gitconfig
        /// Required: True
        /// UpdateType: Mutable
        /// Type: GitConfig
        /// </summary>
        public GitConfig GitConfig
        {
            get;
            set;
        }
    }

    namespace CodeRepositoryTypes
    {
        public class GitConfig
        {
            /// <summary>
            /// SecretArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-secretarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic SecretArn
            {
                get;
                set;
            }

            /// <summary>
            /// Branch
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-branch
            /// Required: False
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Branch
            {
                get;
                set;
            }

            /// <summary>
            /// RepositoryUrl
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-sagemaker-coderepository-gitconfig.html#cfn-sagemaker-coderepository-gitconfig-repositoryurl
            /// Required: True
            /// UpdateType: Immutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic RepositoryUrl
            {
                get;
                set;
            }
        }
    }
}