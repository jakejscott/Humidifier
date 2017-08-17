namespace Humidifier.CloudTrail
{
    using System.Collections.Generic;
    using TrailPropertyTypes;

    public class Trail : Humidifier.Resource
    {
        /// <summary>
        /// CloudWatchLogsLogGroupArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-cloudwatchlogsloggroupaem
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudWatchLogsLogGroupArn
        {
            get;
            set;
        }

        /// <summary>
        /// CloudWatchLogsRoleArn
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-cloudwatchlogsrolearn
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic CloudWatchLogsRoleArn
        {
            get;
            set;
        }

        /// <summary>
        /// EnableLogFileValidation
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-enablelogfilevalidation
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? EnableLogFileValidation
        {
            get;
            set;
        }

        /// <summary>
        /// IncludeGlobalServiceEvents
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-includeglobalserviceevents
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? IncludeGlobalServiceEvents
        {
            get;
            set;
        }

        /// <summary>
        /// IsLogging
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-islogging
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool IsLogging
        {
            get;
            set;
        }

        /// <summary>
        /// IsMultiRegionTrail
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-ismultiregiontrail
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: Boolean
        /// </summary>
        public bool ? IsMultiRegionTrail
        {
            get;
            set;
        }

        /// <summary>
        /// KMSKeyId
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-kmskeyid
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic KMSKeyId
        {
            get;
            set;
        }

        /// <summary>
        /// S3BucketName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-s3bucketname
        /// Required: True
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3BucketName
        {
            get;
            set;
        }

        /// <summary>
        /// S3KeyPrefix
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-s3keyprefix
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic S3KeyPrefix
        {
            get;
            set;
        }

        /// <summary>
        /// SnsTopicName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-snstopicname
        /// Required: False
        /// UpdateType: Mutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic SnsTopicName
        {
            get;
            set;
        }

        /// <summary>
        /// Tags
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#cfn-cloudtrail-trail-tags
        /// Required: False
        /// UpdateType: Mutable
        /// Type: List
        /// ItemType: Tag
        /// </summary>
        public List<Tag> Tags
        {
            get;
            set;
        }

        /// <summary>
        /// TrailName
        /// http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-cloudtrail-trail.html#aws-cloudtrail-trail-trailname
        /// Required: False
        /// UpdateType: Immutable
        /// PrimitiveType: String
        /// </summary>
        public dynamic TrailName
        {
            get;
            set;
        }
    }

    namespace TrailPropertyTypes
    {
    }
}