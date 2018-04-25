using Amazon;
using Amazon.CloudFormation;
using Amazon.Lambda;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.SimpleSystemsManagement;
using Humidifier.Json;

namespace ProjectBaseName.DeployTool
{
    public class Context
    {
        public Config Config { get; set; }
        public JsonStackSerializer JsonStackSerializer { get; set; }
        public RegionEndpoint Region { get; set; }
        public AWSCredentials AwsCredentials { get; set; }
        public IAmazonCloudFormation Cloudformation { get; set; }
        public IAmazonS3 S3 { get; set; }
        public IAmazonSimpleSystemsManagement SSM { get; set; }
        public IAmazonLambda Lambda { get; set; }
    }
}