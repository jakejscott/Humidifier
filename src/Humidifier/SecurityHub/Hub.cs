namespace Humidifier.SecurityHub
{
    using System.Collections.Generic;

    public class Hub : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecurityHub::Hub";
            }
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-securityhub-hub.html#cfn-securityhub-hub-tags
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic Tags
        {
            get;
            set;
        }
    }
}