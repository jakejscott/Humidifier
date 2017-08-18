namespace Humidifier.OpsWorks
{
    using System.Collections.Generic;
    using UserProfilePropertyTypes;

    public class UserProfile : Humidifier.Resource
    {
        public static class Attributes
        {
            public static string SshUsername =  "SshUsername" ;
        }

        /// <summary>
        /// AllowSelfManagement
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-allowselfmanagement
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public dynamic AllowSelfManagement
        {
            get;
            set;
        }

        /// <summary>
        /// IamUserArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-iamuserarn
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic IamUserArn
        {
            get;
            set;
        }

        /// <summary>
        /// SshPublicKey
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshpublickey
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SshPublicKey
        {
            get;
            set;
        }

        /// <summary>
        /// SshUsername
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-opsworks-userprofile.html#cfn-opsworks-userprofile-sshusername
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SshUsername
        {
            get;
            set;
        }
    }

    namespace UserProfilePropertyTypes
    {
    }
}