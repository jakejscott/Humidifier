namespace Humidifier.AppStream
{
    using System.Collections.Generic;
    using DirectoryConfigTypes;

    public class DirectoryConfig : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::AppStream::DirectoryConfig";
            }
        }

        /// <summary>
        /// OrganizationalUnitDistinguishedNames
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-organizationalunitdistinguishednames
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public dynamic OrganizationalUnitDistinguishedNames
        {
            get;
            set;
        }

        /// <summary>
        /// ServiceAccountCredentials
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-serviceaccountcredentials
        /// Required: True
        /// UpdateType: Mutable
        /// Type: ServiceAccountCredentials
        /// </summary>
        public ServiceAccountCredentials ServiceAccountCredentials
        {
            get;
            set;
        }

        /// <summary>
        /// DirectoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-appstream-directoryconfig.html#cfn-appstream-directoryconfig-directoryname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic DirectoryName
        {
            get;
            set;
        }
    }

    namespace DirectoryConfigTypes
    {
        public class ServiceAccountCredentials
        {
            /// <summary>
            /// AccountName
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-serviceaccountcredentials.html#cfn-appstream-directoryconfig-serviceaccountcredentials-accountname
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountName
            {
                get;
                set;
            }

            /// <summary>
            /// AccountPassword
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-appstream-directoryconfig-serviceaccountcredentials.html#cfn-appstream-directoryconfig-serviceaccountcredentials-accountpassword
            /// Required: True
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic AccountPassword
            {
                get;
                set;
            }
        }
    }
}