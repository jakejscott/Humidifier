namespace Humidifier.IAM
{
    using System.Collections.Generic;
    using InstanceProfilePropertyTypes;

    public class InstanceProfile : Humidifier.Resource
    {
        /// <summary>
        /// InstanceProfileName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-instanceprofilename
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic InstanceProfileName
        {
            get;
            set;
        }

        /// <summary>
        /// Path
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-path
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Path
        {
            get;
            set;
        }

        /// <summary>
        /// Roles
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-iam-instanceprofile.html#cfn-iam-instanceprofile-roles
        /// Required: True
        /// UpdateType: Mutable
        /// Type: List
        /// PrimitiveItemType: String
        /// </summary>
        public List<dynamic> Roles
        {
            get;
            set;
        }
    }

    namespace InstanceProfilePropertyTypes
    {
    }
}