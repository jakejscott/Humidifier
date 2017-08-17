namespace Humidifier.S3
{
    using System.Collections.Generic;
    using BucketPolicyPropertyTypes;

    public class BucketPolicy : Humidifier.Resource
    {
        /// <summary>
        /// Bucket
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#cfn-s3-bucketpolicy-bucket
        /// Required: True
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic Bucket
        {
            get;
            set;
        }

        /// <summary>
        /// PolicyDocument
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-policy.html#cfn-s3-bucketpolicy-policydocument
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Json
        /// </summary>
        public dynamic PolicyDocument
        {
            get;
            set;
        }
    }

    namespace BucketPolicyPropertyTypes
    {
    }
}