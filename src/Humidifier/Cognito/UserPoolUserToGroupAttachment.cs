namespace Humidifier.Cognito
{
    using System.Collections.Generic;
    using UserPoolUserToGroupAttachmentPropertyTypes;

    public class UserPoolUserToGroupAttachment : Humidifier.Resource
    {
        /// <summary>
        /// GroupName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-groupname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic GroupName
        {
            get;
            set;
        }

        /// <summary>
        /// UserPoolId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-userpoolid
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic UserPoolId
        {
            get;
            set;
        }

        /// <summary>
        /// Username
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-cognito-userpoolusertogroupattachment.html#cfn-cognito-userpoolusertogroupattachment-username
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Username
        {
            get;
            set;
        }
    }

    namespace UserPoolUserToGroupAttachmentPropertyTypes
    {
    }
}