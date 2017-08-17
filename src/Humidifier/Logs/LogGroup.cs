namespace Humidifier.Logs
{
    using System.Collections.Generic;
    using LogGroupPropertyTypes;

    public class LogGroup : Humidifier.Resource
    {
        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-cwl-loggroup-loggroupname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// RetentionInDays
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-loggroup.html#cfn-cwl-loggroup-retentionindays
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? RetentionInDays
        {
            get;
            set;
        }
    }

    namespace LogGroupPropertyTypes
    {
    }
}