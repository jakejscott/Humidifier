namespace Humidifier.Pinpoint
{
    using System.Collections.Generic;

    public class EventStream : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Pinpoint::EventStream";
            }
        }

        /// <summary>
        /// ApplicationId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-eventstream.html#cfn-pinpoint-eventstream-applicationid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ApplicationId
        {
            get;
            set;
        }

        /// <summary>
        /// DestinationStreamArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-eventstream.html#cfn-pinpoint-eventstream-destinationstreamarn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationStreamArn
        {
            get;
            set;
        }

        /// <summary>
        /// RoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-pinpoint-eventstream.html#cfn-pinpoint-eventstream-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleArn
        {
            get;
            set;
        }
    }
}