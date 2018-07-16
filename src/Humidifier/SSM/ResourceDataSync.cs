namespace Humidifier.SSM
{
    using System.Collections.Generic;

    public class ResourceDataSync : Humidifier.Resource
    {
        public override string AWSTypeName
        {
            get
            {
                return @"AWS::SSM::ResourceDataSync";
            }
        }

        /// <summary>
        /// KMSKeyArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-kmskeyarn
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KMSKeyArn
        {
            get;
            set;
        }

        /// <summary>
        /// BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketName
        {
            get;
            set;
        }

        /// <summary>
        /// BucketRegion
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketregion
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketRegion
        {
            get;
            set;
        }

        /// <summary>
        /// SyncFormat
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-syncformat
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SyncFormat
        {
            get;
            set;
        }

        /// <summary>
        /// SyncName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-syncname
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SyncName
        {
            get;
            set;
        }

        /// <summary>
        /// BucketPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-resource-ssm-resourcedatasync.html#cfn-ssm-resourcedatasync-bucketprefix
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic BucketPrefix
        {
            get;
            set;
        }
    }
}