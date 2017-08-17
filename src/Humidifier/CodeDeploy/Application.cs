namespace Humidifier.CodeDeploy
{
    using System.Collections.Generic;
    using ApplicationPropertyTypes;

    public class Application : Humidifier.Resource
    {
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codedeploy-application.html#cfn-codedeploy-application-applicationname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName
        {
            get;
            set;
        }
    }

    namespace ApplicationPropertyTypes
    {
    }
}