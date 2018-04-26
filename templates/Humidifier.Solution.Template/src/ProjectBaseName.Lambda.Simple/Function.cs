using System;
using System.Threading.Tasks;
using Amazon.CloudWatch;
using Amazon.Lambda.Core;
using ProjectBaseName.Lambda.Common;
using Serilog;
using Serilog.Context;
using Serilog.Formatting.Compact;

[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace ProjectBaseName.Lambda.Simple
{
    public class Function
    {
        private readonly ILogger log;
        private readonly IAmazonCloudWatch cloudwatch;

        public Function() : this(new AmazonCloudWatchClient())
        {
        }

        public Function(IAmazonCloudWatch cloudwatch)
        {
            this.cloudwatch = cloudwatch ?? throw new ArgumentNullException(nameof(cloudwatch));

            log = new LoggerConfiguration()
                .WriteTo.LambdaLogger(new CompactJsonFormatter())
                .CreateLogger();
        }

        public async Task<SimpleFunctionResult> Handler(SimpleFunctionArgs args, ILambdaContext context)
        {
            using (LogContext.PushProperty("awsRequestId", context.AwsRequestId))
            {
                try
                {
                    log.Information("Processing request: Args: {@args}", args);
                    var result = new SimpleFunctionResult { Message = "Hello, " + args.Name };
                    log.Information("Processed request. Result: {@result}", result);
                    await CloudwatchMetrics.PutCountMetricAsync(log, cloudwatch, context.FunctionName, "Success", 1);
                    return result;
                }
                catch (Exception ex)
                {
                    log.Error(ex, "Whoops");
                    await CloudwatchMetrics.PutCountMetricAsync(log, cloudwatch, context.FunctionName, "Errors", 1);
                    throw;
                }
            }
        }
    }
}
