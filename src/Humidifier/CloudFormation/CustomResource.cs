namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class CustomResource : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CloudFormation::CustomResource";
            }
        }

        /// <summary>
        /// ServiceToken
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cfn-customresource.html#cfn-customresource-servicetoken
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceToken
        {
            get;
            set;
        }
    }
}