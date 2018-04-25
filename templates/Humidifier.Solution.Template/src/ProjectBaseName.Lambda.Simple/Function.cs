using System;
using System.Threading.Tasks;
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

        public Function()
        {
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
                    await Task.Delay(10); // Simulate some work...
                    var result = new SimpleFunctionResult { Message = "Hello, " + args.Name };
                    log.Information("Processed request. Result: {@result}", result);
                    return result;
                }
                catch (Exception ex)
                {
                    log.Error(ex, "Simple lambda failed");
                    throw;
                }
            }
        }
    }
}
