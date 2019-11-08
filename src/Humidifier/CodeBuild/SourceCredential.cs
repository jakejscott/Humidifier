namespace Humidifier.CodeBuild
{
    using System.Collections.Generic;

    public class SourceCredential : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CodeBuild::SourceCredential";
            }
        }

        /// <summary>
        /// ServerType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-servertype
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServerType
        {
            get;
            set;
        }

        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-username
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Username
        {
            get;
            set;
        }

        /// <summary>
        /// Token
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-token
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Token
        {
            get;
            set;
        }

        /// <summary>
        /// AuthType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codebuild-sourcecredential.html#cfn-codebuild-sourcecredential-authtype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthType
        {
            get;
            set;
        }
    }
}