namespace Humidifier.SDB
{
    using System.Collections.Generic;

    public class Domain : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SDB::Domain";
            }
        }

        /// <summary>
        /// Description
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-simpledb.html#cfn-sdb-domain-description
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Description
        {
            get;
            set;
        }
    }
}