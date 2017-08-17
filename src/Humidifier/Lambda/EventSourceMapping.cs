namespace Humidifier.Lambda
{
    using System.Collections.Generic;
    using EventSourceMappingPropertyTypes;

    public class EventSourceMapping : Humidifier.Resource
    {
        /// <summary>
        /// BatchSize
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-batchsize
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int ? BatchSize
        {
            get;
            set;
        }

        /// <summary>
        /// Enabled
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-enabled
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? Enabled
        {
            get;
            set;
        }

        /// <summary>
        /// EventSourceArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-eventsourcearn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic EventSourceArn
        {
            get;
            set;
        }

        /// <summary>
        /// FunctionName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-functionname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic FunctionName
        {
            get;
            set;
        }

        /// <summary>
        /// StartingPosition
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lambda-eventsourcemapping.html#cfn-lambda-eventsourcemapping-startingposition
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic StartingPosition
        {
            get;
            set;
        }
    }

    namespace EventSourceMappingPropertyTypes
    {
    }
}