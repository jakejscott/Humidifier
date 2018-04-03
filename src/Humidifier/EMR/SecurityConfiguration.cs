namespace Humidifier.EMR
{
    using System.Collections.Generic;

    public class SecurityConfiguration : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::EMR::SecurityConfiguration";
            }
        }

        /// <summary>
        /// Name
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html#cfn-emr-securityconfiguration-name
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Name
        {
            get;
            set;
        }

        /// <summary>
        /// SecurityConfiguration
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-emr-securityconfiguration.html#cfn-emr-securityconfiguration-securityconfiguration
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic SecurityConfiguration_
        {
            get;
            set;
        }
    }
}