namespace Humidifier.CloudFormation
{
    using System.Collections.Generic;

    public class WaitConditionHandle : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::CloudFormation::WaitConditionHandle";
            }
        }
    }
}