namespace Humidifier.StepFunctions
{
    using System.Collections.Generic;
    using ActivityPropertyTypes;

    public class Activity : Humidifier.Resource
    {
        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-stepfunctions-activity.html#cfn-stepfunctions-activity-name
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }
    }

    namespace ActivityPropertyTypes
    {
    }
}