using System.Threading.Tasks;
using Amazon.CloudWatch;
using Amazon.Lambda.Core;
using Amazon.Lambda.TestUtilities;
using NSubstitute;
using ProjectBaseName.Lambda.Common;
using ProjectBaseName.Lambda.Simple;
using Xunit;

namespace ProjectBaseName.Tests
{
    public class SimpleLambdaTests
    {
        [Fact]
        public async Task Test1()
        {
            ILambdaContext context = new TestLambdaContext();
            IAmazonCloudWatch cloudwatch = Substitute.For<IAmazonCloudWatch>();

            var function = new Function(cloudwatch);

            SimpleFunctionArgs args = new SimpleFunctionArgs { Name = "ProjectBaseName" };
            SimpleFunctionResult result = await function.Handler(args, context);

            Assert.Equal("Hello, ProjectBaseName", result.Message);
        }
    }
}
