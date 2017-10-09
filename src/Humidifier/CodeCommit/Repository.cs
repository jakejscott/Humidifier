namespace Humidifier.CodeCommit
{
    using System.Collections.Generic;
    using RepositoryPropertyTypes;

    public class Repository : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string CloneUrlHttp =  "CloneUrlHttp" ;
            public static string CloneUrlSsh =  "CloneUrlSsh" ;
            public static string Arn =  "Arn" ;
            public static string Name =  "Name" ;
        }

        /// <summary>
        /// RepositoryName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-repositoryname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RepositoryName
        {
            get;
            set;
        }

        /// <summary>
        /// Triggers
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-triggers
        /// Required: False
        /// UpdateType: Conditional
        /// Type: List
        /// ItemType: RepositoryTrigger
        /// </summary>
        public List<RepositoryTrigger> Triggers
        {
            get;
            set;
        }

        /// <summary>
        /// RepositoryDescription
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-codecommit-repository.html#cfn-codecommit-repository-repositorydescription
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic RepositoryDescription
        {
            get;
            set;
        }
    }

    namespace RepositoryPropertyTypes
    {
        public class RepositoryTrigger
        {
            /// <summary>
            /// Events
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-events
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Events
            {
                get;
                set;
            }

            /// <summary>
            /// Branches
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-branches
            /// Required: False
            /// UpdateType: Mutable
            /// Type: List
            /// PrimitiveItemType: String
            /// </summary>
            public dynamic Branches
            {
                get;
                set;
            }

            /// <summary>
            /// CustomData
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-customdata
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic CustomData
            {
                get;
                set;
            }

            /// <summary>
            /// DestinationArn
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-destinationarn
            /// Required: False
            /// UpdateType: Mutable
            /// PrimitiveType: String
            /// </summary>
            public dynamic DestinationArn
            {
                get;
                set;
            }

            /// <summary>
            /// Name
            /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-codecommit-repository-repositorytrigger.html#cfn-codecommit-repository-repositorytrigger-name
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
    }
}