namespace Humidifier.SecretsManager
{
    using System.Collections.Generic;
    using RotationScheduleTypes;

    public class RotationSchedule : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecretsManager::RotationSchedule";
            }
        }

        /// <summary>
        /// SecretId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-secretid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecretId
        {
            get;
            set;
        }

        /// <summary>
        /// RotationLambdaARN
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-rotationlambdaarn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RotationLambdaARN
        {
            get;
            set;
        }

        /// <summary>
        /// RotationRules
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-rotationschedule.html#cfn-secretsmanager-rotationschedule-rotationrules
        /// Required: False
        /// UpdateType: Mutable
        /// Type: RotationRules
        /// </summary>
        public RotationRules RotationRules
        {
            get;
            set;
        }
    }

    namespace RotationScheduleTypes
    {
        public class RotationRules
        {
            /// <summary>
            /// AutomaticallyAfterDays
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-secretsmanager-rotationschedule-rotationrules.html#cfn-secretsmanager-rotationschedule-rotationrules-automaticallyafterdays
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: Integer
            /// </summary>
            public dynamic AutomaticallyAfterDays
            {
                get;
                set;
            }
        }
    }
}