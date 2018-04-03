namespace Humidifier.EC2
{
    using System.Collections.Generic;

    public class PlacementGroup : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EC2::PlacementGroup";
            }
        }

        /// <summary>
        /// Strategy
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ec2-placementgroup.html#cfn-ec2-placementgroup-strategy
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Strategy
        {
            get;
            set;
        }
    }
}