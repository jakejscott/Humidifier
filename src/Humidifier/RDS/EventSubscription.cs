namespace Humidifier.RDS
{
    using System.Collections.Generic;

    public class EventSubscription : Humidifier.Resource
    {
        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html#cfn-rds-eventsubscription-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// EventCategories
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html#cfn-rds-eventsubscription-eventcategories
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic EventCategories
        {
            get;
            set;
        }

        /// <summary>
        /// SnsTopicArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html#cfn-rds-eventsubscription-snstopicarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnsTopicArn
        {
            get;
            set;
        }

        /// <summary>
        /// SourceIds
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html#cfn-rds-eventsubscription-sourceids
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic SourceIds
        {
            get;
            set;
        }

        /// <summary>
        /// SourceType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-rds-eventsubscription.html#cfn-rds-eventsubscription-sourcetype
        /// Required: False
        /// UpdateType: Conditional
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceType
        {
            get;
            set;
        }
    }
}