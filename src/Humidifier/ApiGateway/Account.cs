namespace Humidifier.ApiGateway
{
    using System.Collections.Generic;

    public class Account : Humidifier.Resource
    {
        /// <summary>
        /// CloudWatchRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-apigateway-account.html#cfn-apigateway-account-cloudwatchrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudWatchRoleArn
        {
            get;
            set;
        }
    }
}