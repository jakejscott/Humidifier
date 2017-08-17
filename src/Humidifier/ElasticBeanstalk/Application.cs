namespace Humidifier.ElasticBeanstalk
{
    using System.Collections.Generic;
    using ApplicationPropertyTypes;

    public class Application : Humidifier.Resource
    {
        /// <summary>
        /// ApplicationName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationName
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-beanstalk.html#cfn-elasticbeanstalk-application-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }
    }

    namespace ApplicationPropertyTypes
    {
    }
}