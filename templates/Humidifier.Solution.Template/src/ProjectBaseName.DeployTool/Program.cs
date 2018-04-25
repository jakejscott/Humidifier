using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Amazon;
using Amazon.CloudFormation;
using Amazon.CloudFormation.Model;
using Amazon.Lambda;
using Amazon.Runtime.CredentialManagement;
using Amazon.S3;
using Amazon.SimpleSystemsManagement;
using DotNetEnv;
using Humidifier.Json;
using Microsoft.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using ProjectBaseName.DeployTool.Stacks;
using Serilog;

namespace ProjectBaseName.DeployTool
{
    public static class Program
    {
        private const string sln = "ProjectBaseName.sln";

        public static int Main(string[] args)
        {
            var log = new LoggerConfiguration().WriteTo.Console().MinimumLevel.Debug().CreateLogger();

            try
            {
                var cli = new CommandLineApplication(false) { Name = "ProjectBaseName.DeployTool" };

                cli.HelpOption("-?|-h|--help");

                Register(cli, log, "deploy-base", async context => await BaseStack.Deploy(log, context));
                // Register(cli, log, "deploy-lambda", async context => await BaseStack.Deploy(log, context));

                Register(cli, log, "secrets-encrypt", async context => await Secrets.Encrypt(log, context), login: false);
                Register(cli, log, "secrets-decrypt", async context => await Secrets.Decrypt(log, context), login: false);
                Register(cli, log, "secrets-upload", async context => await Secrets.Upload(log, context));

                if (args.Length == 0) cli.ShowHelp();

                var result = cli.Execute(args);
                log.Information("Exit: {exit}", result);
                return result;
            }
            catch (Exception e)
            {
                log.Error(e is AggregateException ? e.InnerException.Demystify() : e.Demystify(), "Error");
                return -1;
            }
        }

        static Config GetConfig()
        {
            var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();

            string GetConfig(string key) => string.IsNullOrWhiteSpace(config[key]) ? throw new Exception($"Missing config: {key}") : config[key];

            var env = GetConfig("ENV");
            var region = GetConfig("REGION");
            var stack = GetConfig("STACK");
            var profile = GetConfig("PROFILE");
            var buildConfig = GetConfig("BUILD_CONFIG");
            var buildPath = GetConfig("BUILD_PATH");
            var team = GetConfig("TEAM");
            var email = GetConfig("EMAIL");

            var tags = new List<Tag>
            {
                new Tag { Key = "env", Value = env},
                new Tag { Key = "region", Value = region},
                new Tag { Key = "build_config", Value = buildConfig},
                new Tag { Key = "team", Value = team},
                new Tag { Key = "email", Value = email}
            };

            var result = new Config
            {
                Env = env,
                Region = region,
                Stack = stack,
                Team = team,
                Email = email,
                Profile = profile,
                BuildConfig = buildConfig,
                BuildPath = buildPath,
                Tags = tags,
            };            

            return result;
        }

        static void Register(CommandLineApplication cli, ILogger log, string command, Func<Context, Task<bool>> func, bool login = true)
        {
            cli.Command(command, x =>
            {
                var env = x.Option("--env", "environment", CommandOptionType.SingleValue);
                x.HelpOption("-?|-h|--help");

                x.OnExecute(async () =>
                {
                    if (!env.HasValue())
                    {
                        log.Error("--env cli arg missing");
                        x.ShowHelp(command);
                        return -1;
                    }

                    var pwd = Directory.GetCurrentDirectory();
                    var buildPath = FindPath(pwd, sln);
                    if (buildPath == null)
                    {
                        log.Error("Unable to determine build path. pwd: {pwd} sln: {sln}", pwd, sln);
                        return -1;
                    }

                    SetEnvironment(buildPath, env.Value());

                    var config = GetConfig();
                    var context = GetContext(config, login);

                    var success = await func(context);
                    return success ? 0 : 1;
                });
            });
        }

        static Context GetContext(Config config, bool login = true)
        {
            var store = new CredentialProfileStoreChain();
            if (!store.TryGetProfile(config.Profile, out var profile))
            {
                throw new Exception($"Unable to find '{config.Profile}' AWS profile");
            }

            var credentials = profile.GetAWSCredentials(store);
            var region = RegionEndpoint.GetBySystemName(config.Region);

            var result = new Context
            {
                Config = config,
                Region = region,
                AwsCredentials = credentials,
                JsonStackSerializer = new JsonStackSerializer()
            };

            if (login)
            {
                result.Cloudformation = new AmazonCloudFormationClient(credentials, region);
                result.S3 = new AmazonS3Client(credentials, region);
                result.SSM = new AmazonSimpleSystemsManagementClient(credentials, region);
                result.Lambda = new AmazonLambdaClient(credentials, region);
            }

            return result;
        }

        static void SetEnvironment(string buildPath, string env)
        {
            Environment.SetEnvironmentVariable("BUILD_PATH", buildPath);
            Environment.SetEnvironmentVariable("ENV", env);
            var dotenvPath = Path.Combine(buildPath, $".{env}.env");
            if (File.Exists(dotenvPath)) Env.Load(dotenvPath);
        }

        static string FindPath(string path, string searchPattern)
        {
            var files = Directory.GetFiles(path, searchPattern, SearchOption.TopDirectoryOnly);
            if (files.Any()) return path;
            var parent = Directory.GetParent(path);
            if (parent.Exists) return FindPath(parent.FullName, searchPattern);
            return null;
        }
    }
}