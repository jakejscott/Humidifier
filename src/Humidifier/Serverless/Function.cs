namespace Humidifier.Serverless
{
    // TODO: Support Serverless Application Model
    // https://github.com/awslabs/serverless-application-model/blob/master/versions/2016-10-31.md
    // Example of a custom resource.

    public class Function : Resource
    {
        public override string AWSTypeName => "AWS::Serverless::Function";

        public dynamic Handler { get; set; }
        public dynamic Runtime { get; set; }
        public dynamic CodeUri { get; set; }
    }
}