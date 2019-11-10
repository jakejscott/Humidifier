namespace Humidifier.LakeFormation
{
    using System.Collections.Generic;
    using DataLakeSettingsTypes;

    public class DataLakeSettings : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::LakeFormation::DataLakeSettings";
            }
        }

        /// <summary>
        /// Admins
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-datalakesettings.html#cfn-lakeformation-datalakesettings-admins
        /// Required: False
        /// UpdateType: Mutable
        /// Type: Admins
        /// </summary>
        public Admins Admins
        {
            get;
            set;
        }
    }

    namespace DataLakeSettingsTypes
    {
        public class DataLakePrincipal
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-datalakesettings-datalakeprincipal.html#cfn-lakeformation-datalakesettings-datalakeprincipal-datalakeprincipalidentifier
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DataLakePrincipalIdentifier
            {
                get;
                set;
            }
        }

        public class Admins
        {
        }
    }
}