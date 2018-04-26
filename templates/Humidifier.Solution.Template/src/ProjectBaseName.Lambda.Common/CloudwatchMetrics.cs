using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Amazon.CloudWatch;
using Amazon.CloudWatch.Model;
using Serilog;

namespace ProjectBaseName.Lambda.Common
{
    public static class CloudwatchMetrics
    {
        public static async Task PutMillisecondsMetricAsync(ILogger log, IAmazonCloudWatch cloudwatch, string functionName, string metricName, long milliseconds)
        {
            try
            {
                var request = new PutMetricDataRequest { Namespace = functionName };
                var metric = new MetricDatum
                {
                    MetricName = metricName,
                    Timestamp = DateTime.UtcNow,
                    Unit = StandardUnit.Milliseconds,
                    Value = milliseconds,
                    Dimensions = new List<Dimension>
                    {
                        new Dimension
                        {
                            Name = "FunctionName",
                            Value = functionName
                        }
                    }
                };
                request.MetricData.Add(metric);
                await cloudwatch.PutMetricDataAsync(request).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                log.Error(ex.Demystify(), "Cloudwatch put milliseconds metric failed. MetricName: {metricName} Milliseconds: {milliseconds}", metricName, milliseconds);
            }
        }

        public static async Task PutCountMetricAsync(ILogger log, IAmazonCloudWatch cloudwatch, string functionName, string metricName, int count)
        {
            try
            {
                var request = new PutMetricDataRequest { Namespace = functionName };
                var metric = new MetricDatum
                {
                    MetricName = metricName,
                    Timestamp = DateTime.UtcNow,
                    Unit = StandardUnit.Count,
                    Value = count,
                    Dimensions = new List<Dimension>
                    {
                        new Dimension
                        {
                            Name = "FunctionName",
                            Value = functionName
                        }
                    }
                };
                request.MetricData.Add(metric);
                await cloudwatch.PutMetricDataAsync(request).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                log.Error(ex.Demystify(), "Cloudwatch put count metric failed. MetricName: {metricName} Count: {count}.", metricName, count);
            }
        }
    }
}