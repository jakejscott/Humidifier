namespace Humidifier.IAM
{
    using System.Collections.Generic;

    public class ServiceLinkedRole : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::IAM::ServiceLinkedRole";
            }
        }

        /// <summary>
        /// CustomSuffix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-servicelinkedrole.html#cfn-iam-servicelinkedrole-customsuffix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CustomSuffix
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-servicelinkedrole.html#cfn-iam-servicelinkedrole-description
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
        /// AWSServiceName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-servicelinkedrole.html#cfn-iam-servicelinkedrole-awsservicename
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AWSServiceName
        {
            get;
            set;
        }
    }
}