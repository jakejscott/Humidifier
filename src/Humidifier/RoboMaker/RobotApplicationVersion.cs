namespace Humidifier.RoboMaker
{
    using System.Collections.Generic;

    public class RobotApplicationVersion : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::RoboMaker::RobotApplicationVersion";
            }
        }

        /// <summary>
        /// CurrentRevisionId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html#cfn-robomaker-robotapplicationversion-currentrevisionid
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CurrentRevisionId
        {
            get;
            set;
        }

        /// <summary>
        /// Application
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-robomaker-robotapplicationversion.html#cfn-robomaker-robotapplicationversion-application
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Application
        {
            get;
            set;
        }
    }
}