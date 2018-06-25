using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Humidifier;
using Humidifier.IAM;
using Humidifier.Lambda.FunctionTypes;
using ProjectBaseName.DeployTool.Util;
using ProjectBaseName.Lambda.Common;
using Serilog;

namespace ProjectBaseName.DeployTool.Stacks
{
    public static class SimpleStack
    {
        public static string Name(Config config) => config.Stack + "-simple-" + config.Env;
        private static string Namespace = "ProjectBaseName.Lambda.Simple";
        private static readonly string Handler = $"{Namespace}::{Namespace}.Function::Handler";

        public static async Task<bool> Deploy(ILogger log, Context context)
        {
            var stack = Build();
            var template = context.JsonStackSerializer.Serialize(stack);
            var cwd = Path.Combine(context.Config.BuildPath, "src", Namespace);

            var baseStack = await Cloudformation.GetExistingStackAsync(context.Cloudformation, BaseStack.Name(context.Config)).ConfigureAwait(false);
            if (baseStack == null)
            {
                log.Error("Deploy the {stackName} stack first.", BaseStack.Name(context.Config));
                return false;
            }

            var bucket = baseStack.GetStackOutput("DeploymentsBucket");
            var role = baseStack.GetStackOutput("CloudFormationServiceRole");

            var parameters = new Dictionary<string, string>
            {
                ["Environment"] = context.Config.Env,
                ["DeploymentsBucket"] = bucket
            };

            return await LambdaDeployer.DeployStackAsync(log, context, Name(context.Config), template, cwd, parameters, bucket, role).ConfigureAwait(false);
        }

        private static Stack Build()
        {
            var stack = new Stack { Description = "Simple lambda stack" };

            stack.Parameters.Add("Environment", new Parameter { Type = "String", MinLength = 3, AllowedValues = new List<string> { "test", "uat", "prod" } });
            stack.Parameters.Add("DeploymentsBucket", new Parameter { Type = "String", MinLength = 3 });
            stack.Parameters.Add("DeploymentsKey", new Parameter { Type = "String", MinLength = 3 });
            stack.Parameters.Add("MemorySize", new Parameter { Type = "Number", Default = "512", MinValue = 128, MaxValue = 1536 });

            stack.Resources.Add("FunctionRole", new Role
            {
                AssumeRolePolicyDocument = new PolicyDocument
                {
                    Version = "2012-10-17",
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Effect = "Allow",
                            Principal = new { Service = "lambda.amazonaws.com" },
                            Action = "sts:AssumeRole"
                        }
                    }
                },
                ManagedPolicyArns = new List<dynamic>
                {
                    Fn.Ref("FunctionPolicy")
                }
            });

            stack.Resources.Add("FunctionPolicy", new ManagedPolicy
            {
                PolicyDocument = new PolicyDocument
                {
                    Version = "2012-10-17",
                    Statement = new List<Statement>
                    {
                        new Statement
                        {
                            Action = new[]
                            {
                                "cloudwatch:getMetricData",
                                "cloudwatch:getMetricStatistics",
                                "cloudwatch:listMetrics",
                                "cloudwatch:putMetricAlarm",
                                "cloudwatch:putMetricData"
                            },
                            Effect = "Allow",
                            Resource = "*",
                        },
                        new Statement
                        {
                            Action = new[]
                            {
                                "events:DescribeRule",
                                "events:ListRules",
                                "events:ListTargetsByRule",
                                "events:PutEvents",
                                "events:PutRule",
                                "events:PutTargets"
                            },
                            Effect = "Allow",
                            Resource = "*"
                        },
                        new Statement
                        {
                            Action = new[]
                            {
                                "logs:CreateLogGroup",
                                "logs:CreateLogStream",
                                "logs:PutLogEvents"
                            },
                            Effect = "Allow",
                            Resource = "arn:aws:logs:*:*:*"
                        },
                        new Statement
                        {
                            Action = "xray:*",
                            Effect = "Allow",
                            Resource = "*"
                        }
                    }
                }
            });

            stack.Resources.Add("Function", new Humidifier.Lambda.Function
            {
                FunctionName = Fn.Ref("AWS::StackName"),
                Timeout = 300,
                Runtime = "dotnetcore2.0",
                Handler = Handler,
                MemorySize = Fn.Ref("MemorySize"),
                Role = Fn.GetAtt("FunctionRole", "Arn"),
                Code = new Code
                {
                    S3Bucket = Fn.Ref("DeploymentsBucket"),
                    S3Key = Fn.Ref("DeploymentsKey"),
                },
                Environment = new Environment
                {
                    Variables = new Dictionary<string, dynamic>
                    {
                        ["Environment"] = Fn.Ref("Environment")
                    }
                }
            });

            return stack;
        }

        public static async Task<bool> Invoke(ILogger log, Context context)
        {
            var args = new SimpleFunctionArgs { Name = "ProjectBaseName" };
            log.Information("Invoking lambda with args: {@args}", args);
            var result = await LambdaInvoker.Invoke<SimpleFunctionArgs, SimpleFunctionResult>(log, context, args, Name(context.Config));
            log.Information("Lambda result: {@result}", result);
            return true;
        }

        public static async Task<bool> Destroy(ILogger log, Context context)
        {
            var baseStack = await Cloudformation.GetExistingStackAsync(context.Cloudformation, BaseStack.Name(context.Config)).ConfigureAwait(false);
            if (baseStack == null)
            {
                log.Error("Deploy the {stackName} stack first.", BaseStack.Name(context.Config));
                return false;
            }

            var role = baseStack.GetStackOutput("CloudFormationServiceRole");

            var result = await Cloudformation.DeleteStackAsync(log, context.Cloudformation, Name(context.Config), role);
            return result;
        }
    }
};
