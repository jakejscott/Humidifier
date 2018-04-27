using System;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Amazon.Lambda;
using Amazon.Lambda.Model;
using Newtonsoft.Json;
using Serilog;

namespace ProjectBaseName.DeployTool.Util
{
    public static class LambdaInvoker
    {
        public static async Task<TResult> Invoke<TArgs, TResult>(ILogger log, Context context, TArgs args, string functionName)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.None,
                Formatting = Formatting.None
            };

            var payload = JsonConvert.SerializeObject(args, jsonSettings);

            var request = new InvokeRequest
            {
                FunctionName = functionName,
                Payload = payload,
                LogType = LogType.Tail,
                InvocationType = InvocationType.RequestResponse
            };

            InvokeResponse response = await context.Lambda.InvokeAsync(request).ConfigureAwait(false);

            var reader = new StreamReader(response.Payload);
            var json = reader.ReadToEnd();

            var bytes = Convert.FromBase64String(response.LogResult);
            var logs = Encoding.UTF8.GetString(bytes);

            log.Information("Logs:\n" + logs);

            if (!string.IsNullOrWhiteSpace(response.FunctionError))
            {
                log.Error("FunctionError:\n{error}", json);
                return default;
            }
            else
            {
                TResult result = JsonConvert.DeserializeObject<TResult>(json);
                return result;
            }
        }
    }
}