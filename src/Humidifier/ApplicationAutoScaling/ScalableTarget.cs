namespace Humidifier.ApplicationAutoScaling
{
    using System.Collections.Generic;
    using ScalableTargetPropertyTypes;

    public class ScalableTarget : Humidifier.Resource
    {
        /// <summary>
        /// MaxCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-maxcapacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int MaxCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// MinCapacity
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-mincapacity
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public int MinCapacity
        {
            get;
            set;
        }

        /// <summary>
        /// ResourceId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-resourceid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ResourceId
        {
            get;
            set;
        }

        /// <summary>
        /// RoleARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-rolearn
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RoleARN
        {
            get;
            set;
        }

        /// <summary>
        /// ScalableDimension
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-scalabledimension
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ScalableDimension
        {
            get;
            set;
        }

        /// <summary>
        /// ServiceNamespace
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-applicationautoscaling-scalabletarget.html#cfn-applicationautoscaling-scalabletarget-servicenamespace
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ServiceNamespace
        {
            get;
            set;
        }
    }

    namespace ScalableTargetPropertyTypes
    {
    }
}