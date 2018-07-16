namespace Humidifier.Config
{
    using System.Collections.Generic;

    public class AggregationAuthorization : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::Config::AggregationAuthorization";
            }
        }

        /// <summary>
        /// AuthorizedAccountId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-authorizedaccountid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizedAccountId
        {
            get;
            set;
        }

        /// <summary>
        /// AuthorizedAwsRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-config-aggregationauthorization.html#cfn-config-aggregationauthorization-authorizedawsregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic AuthorizedAwsRegion
        {
            get;
            set;
        }
    }
}