namespace Humidifier.DLM
{
    using System.Collections.Generic;
    using LifecyclePolicyTypes;

    public class LifecyclePolicy : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string Arn =  "Arn" ;
        }

        public override string AWSTypeName
        {
            get
            {
                return @"AWS::DLM::LifecyclePolicy";
            }
        }

        /// <summary>
        /// ExecutionRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-executionrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-description
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
        /// State
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-state
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic State
        {
            get;
            set;
        }

        /// <summary>
        /// PolicyDetails
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-dlm-lifecyclepolicy.html#cfn-dlm-lifecyclepolicy-policydetails
        /// Required: False
        /// UpdateType: Mutable
        /// Type: PolicyDetails
        /// </summary>
        public PolicyDetails PolicyDetails
        {
            get;
            set;
        }
    }

    namespace LifecyclePolicyTypes
    {
        public class Schedule
        {
            /// <summary>
            /// TagsToAdd
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-tagstoadd
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> TagsToAdd
            {
                get;
                set;
            }

            /// <summary>
            /// CreateRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-createrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: CreateRule
            /// </summary>
            public CreateRule CreateRule
            {
                get;
                set;
            }

            /// <summary>
            /// RetainRule
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-retainrule
            /// Required: False
            /// UpdateType: Mutable
            /// Type: RetainRule
            /// </summary>
            public RetainRule RetainRule
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }

            /// <summary>
            /// CopyTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-schedule.html#cfn-dlm-lifecyclepolicy-schedule-copytags
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Boolean
            /// </summary>
            public dynamic CopyTags
            {
                get;
                set;
            }
        }

        public class CreateRule
        {
            /// <summary>
            /// IntervalUnit
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-intervalunit
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic IntervalUnit
            {
                get;
                set;
            }

            /// <summary>
            /// Times
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-times
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Times
            {
                get;
                set;
            }

            /// <summary>
            /// Interval
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-createrule.html#cfn-dlm-lifecyclepolicy-createrule-interval
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Interval
            {
                get;
                set;
            }
        }

        public class RetainRule
        {
            /// <summary>
            /// Count
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-retainrule.html#cfn-dlm-lifecyclepolicy-retainrule-count
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic Count
            {
                get;
                set;
            }
        }

        public class PolicyDetails
        {
            /// <summary>
            /// ResourceTypes
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-resourcetypes
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic ResourceTypes
            {
                get;
                set;
            }

            /// <summary>
            /// Schedules
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-schedules
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Schedule
            /// </summary>
            public List<Schedule> Schedules
            {
                get;
                set;
            }

            /// <summary>
            /// TargetTags
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-dlm-lifecyclepolicy-policydetails.html#cfn-dlm-lifecyclepolicy-policydetails-targettags
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// ItemType: Tag
            /// </summary>
            public List<Tag> TargetTags
            {
                get;
                set;
            }
        }
    }
}