namespace Humidifier.Logs
{
    using System.Collections.Generic;
    using SubscriptionFilterPropertyTypes;

    public class SubscriptionFilter : Humidifier.Resource
    {
        /// <summary>
        /// DestinationArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-destinationarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationArn
        {
            get;
            set;
        }

        /// <summary>
        /// FilterPattern
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-filterpattern
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FilterPattern
        {
            get;
            set;
        }

        /// <summary>
        /// LogGroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-loggroupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic LogGroupName
        {
            get;
            set;
        }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-logs-subscriptionfilter.html#cfn-cwl-subscriptionfilter-rolearn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn
        {
            get;
            set;
        }
    }

    namespace SubscriptionFilterPropertyTypes
    {
    }
}