namespace Humidifier.SecretsManager
{
    using System.Collections.Generic;

    public class SecretTargetAttachment : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SecretsManager::SecretTargetAttachment";
            }
        }

        /// <summary>
        /// SecretId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secrettargetattachment.html#cfn-secretsmanager-secrettargetattachment-secretid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SecretId
        {
            get;
            set;
        }

        /// <summary>
        /// TargetType
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secrettargetattachment.html#cfn-secretsmanager-secrettargetattachment-targettype
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetType
        {
            get;
            set;
        }

        /// <summary>
        /// TargetId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-secretsmanager-secrettargetattachment.html#cfn-secretsmanager-secrettargetattachment-targetid
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TargetId
        {
            get;
            set;
        }
    }
}