using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Serilog;

namespace ProjectBaseName.DeployTool.Util
{
    public static class LambdaDeployer
    {
        public static async Task<bool> DeployStackAsync(ILogger log, Context context, string stackName, string template, string cwd, Dictionary<string, string> parameters, string bucket, string cloudformationRole)
        {
            log.Information("Deploying stack: {stackName}", stackName);

            var ticks = DateTime.Now.Ticks;
            var zipName = $"{stackName}-{ticks}.zip";
            var zipPath = Path.Combine(cwd, zipName);
            var templateName = $"{stackName}-{ticks}.template";

            parameters["CodeS3Key"] = zipName;

            try
            {
                if (!Package(log, context.Config.BuildConfig, cwd, zipName))
                {
                    return false;
                }

                log.Information("Uploading code to bucket {bucket}", bucket);
                await UploadAsync(log, context.S3, bucket, zipName, zipPath).ConfigureAwait(false);

                log.Information("Uploading template to bucket {bucket}", bucket);
                await UploadString(context.S3, bucket, templateName, template).ConfigureAwait(false);

                var templateUrl = new Uri($"https://s3.amazonaws.com/{bucket}/{templateName}");

                var result = await Cloudformation.DeployStackAsync(log, context.Cloudformation, ticks, stackName, context.Config.Tags, parameters, templateUrl: templateUrl, roleArn: cloudformationRole).ConfigureAwait(false);
                return result != DeployStackResult.Failed;
            }
            finally
            {
                try
                {
                    File.Delete(zipPath);
                }
                catch
                {
                    // ignored 
                }
            }
        }

        static bool Package(ILogger log, string configuration, string cwd, string zipName)
        {
            var framework = "netcoreapp2.0";

            if (!RunExecutable(log, "dotnet", "restore", cwd))
            {
                log.Error("Error restoring packages. Cwd: {cwd}. ZipName: {zipName}", cwd, zipName);
                return false;
            }

            var arguments = $"lambda package --output-package {zipName} --project-location {cwd} --framework {framework} --configuration {configuration}";

            if (!RunExecutable(log, "dotnet", arguments, cwd))
            {
                log.Error("Error packaging lambda. Cwd: {cwd}. ZipName: {zipName}", cwd, zipName);
                return false;
            }

            return true;
        }

        static bool RunExecutable(ILogger log, string fileName, string arguments, string cwd)
        {
            var command = new ProcessStartInfo
            {
                FileName = fileName,
                Arguments = arguments,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = cwd,
            };

            using (var process = new Process { StartInfo = command })
            {
                process.OutputDataReceived += (sender, e) => log.Information(e.Data);
                process.ErrorDataReceived += (sender, e) => log.Information(e.Data);
                process.Start();
                process.BeginOutputReadLine();
                process.WaitForExit();
                return process.ExitCode == 0;
            }
        }

        static async Task UploadAsync(ILogger log, IAmazonS3 s3, string deploymentBucket, string zipName, string filePath)
        {
            var transfer = new TransferUtility(s3);
            var request = new TransferUtilityUploadRequest { Key = zipName, BucketName = deploymentBucket, FilePath = filePath };
            request.UploadProgressEvent += (sender, progress) => { log.Information($"... {progress.PercentDone}%"); };
            await transfer.UploadAsync(request).ConfigureAwait(false);
        }

        static async Task UploadString(IAmazonS3 s3, string bucketName, string key, string contentBody)
        {
            var request = new PutObjectRequest { Key = key, BucketName = bucketName, ContentBody = contentBody };
            await s3.PutObjectAsync(request).ConfigureAwait(false);
        }
    }
}