namespace Humidifier.EC2
{
    using System.Collections.Generic;
    using TrafficMirrorFilterRuleTypes;

    public class TrafficMirrorFilterRule : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::TrafficMirrorFilterRule";
            }
        }

        /// <summary>
        /// DestinationPortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-destinationportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrafficMirrorPortRange
        /// </summary>
        public TrafficMirrorPortRange DestinationPortRange
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }

        /// <summary>
        /// SourcePortRange
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-sourceportrange
        /// Required: False
        /// UpdateType: Mutable
        /// Type: TrafficMirrorPortRange
        /// </summary>
        public TrafficMirrorPortRange SourcePortRange
        {
            get;
            set;
        }

        /// <summary>
        /// RuleAction
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-ruleaction
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RuleAction
        {
            get;
            set;
        }

        /// <summary>
        /// SourceCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-sourcecidrblock
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SourceCidrBlock
        {
            get;
            set;
        }

        /// <summary>
        /// RuleNumber
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-rulenumber
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic RuleNumber
        {
            get;
            set;
        }

        /// <summary>
        /// DestinationCidrBlock
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-destinationcidrblock
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DestinationCidrBlock
        {
            get;
            set;
        }

        /// <summary>
        /// TrafficMirrorFilterId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorfilterid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrafficMirrorFilterId
        {
            get;
            set;
        }

        /// <summary>
        /// TrafficDirection
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-trafficdirection
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrafficDirection
        {
            get;
            set;
        }

        /// <summary>
        /// Protocol
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-trafficmirrorfilterrule.html#cfn-ec2-trafficmirrorfilterrule-protocol
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Integer
        /// </summary>
        public dynamic Protocol
        {
            get;
            set;
        }
    }

    namespace TrafficMirrorFilterRuleTypes
    {
        public class TrafficMirrorPortRange
        {
            /// <summary>
            /// FromPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-trafficmirrorfilterrule-trafficmirrorportrange.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorportrange-fromport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic FromPort
            {
                get;
                set;
            }

            /// <summary>
            /// ToPort
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-trafficmirrorfilterrule-trafficmirrorportrange.html#cfn-ec2-trafficmirrorfilterrule-trafficmirrorportrange-toport
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic ToPort
            {
                get;
                set;
            }
        }
    }
}