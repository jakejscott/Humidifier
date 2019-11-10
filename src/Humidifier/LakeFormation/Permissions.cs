namespace Humidifier.LakeFormation
{
    using System.Collections.Generic;
    using PermissionsTypes;

    public class Permissions : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::LakeFormation::Permissions";
            }
        }

        /// <summary>
        /// DataLakePrincipal
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-datalakeprincipal
        /// Required: True
        /// UpdateType: Mutable
        /// Type: DataLakePrincipal
        /// </summary>
        public DataLakePrincipal DataLakePrincipal
        {
            get;
            set;
        }

        /// <summary>
        /// Resource
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-resource
        /// Required: True
        /// UpdateType: Mutable
        /// Type: Resource
        /// </summary>
        public Resource Resource
        {
            get;
            set;
        }

        /// <summary>
        /// Permissions
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissions
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic Permissions_
        {
            get;
            set;
        }

        /// <summary>
        /// PermissionsWithGrantOption
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-lakeformation-permissions.html#cfn-lakeformation-permissions-permissionswithgrantoption
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic PermissionsWithGrantOption
        {
            get;
            set;
        }
    }

    namespace PermissionsTypes
    {
        public class DatabaseResource
        {
            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-databaseresource.html#cfn-lakeformation-permissions-databaseresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class DataLakePrincipal
        {
            /// <summary>
            /// DataLakePrincipalIdentifier
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-datalakeprincipal.html#cfn-lakeformation-permissions-datalakeprincipal-datalakeprincipalidentifier
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

        public class TableResource
        {
            /// <summary>
            /// DatabaseName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-databasename
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DatabaseName
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-tableresource.html#cfn-lakeformation-permissions-tableresource-name
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic Name
            {
                get;
                set;
            }
        }

        public class Resource
        {
            /// <summary>
            /// TableResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-tableresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: TableResource
            /// </summary>
            public TableResource TableResource
            {
                get;
                set;
            }

            /// <summary>
            /// DatabaseResource
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-lakeformation-permissions-resource.html#cfn-lakeformation-permissions-resource-databaseresource
            /// Required: False
            /// UpdateType: Mutable
            /// Type: DatabaseResource
            /// </summary>
            public DatabaseResource DatabaseResource
            {
                get;
                set;
            }
        }
    }
}