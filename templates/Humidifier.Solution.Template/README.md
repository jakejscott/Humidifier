# ProjectBaseName

## Quickstart

In this quickstart we will build, deploy and test a simple lambda function. 

Step 1: Build the solution:

```ps
dotnet build .\ProjectBaseName.sln
```

Step 2: Change directory to the deploy tool folder:

```ps
cd .\src\ProjectBaseName.DeployTool
```

Step 3: Deploy the **base** infrastructure stack:

This will provision a deployments bucket that will have code and cloudformation templates uploaded to it.

```ps
dotnet run deploy-base --env=$env$
```
Wait for the cloudformation to provision the stack. If successful you should see `CREATE_COMPLETE` in the output.

Step 4: Deploy the **simple** lambda stack.

This will package the lambda function code and associated cloudformation template and upload it to the deployments bucket. It will then kick off the cloudformation deployment.

```ps
dotnet run deploy-simple --env=$env$
```

Wait for cloudformation to provision the stack. Again, if successful you should see `CREATE_COMPLETE` in the output.

Step 5: Invoke the **simple** lambda

```ps
dotnet run invoke-simple --env=$env$
```

You should see output similar to this:

```ps
[11:58:48 INF] Invoking lambda with args: {"Name": "ProjectBaseName", "$type": "SimpleFunctionArgs"}
[11:58:52 INF] Logs:
START RequestId: c3cad570-49ad-11e8-8d97-27c7270cd45f Version: $LATEST
{"@t":"2018-04-26T23:58:51.2778076Z","@mt":"Processing request: Args: {@args}","args":{"Name":"ProjectBaseName","$type":"SimpleFunctionArgs"}}
{"@t":"2018-04-26T23:58:51.3352382Z","@mt":"Processed request. Result: {@result}","result":{"Message":"Hello, ProjectBaseName","$type":"SimpleFunctionResult"}}
END RequestId: c3cad570-49ad-11e8-8d97-27c7270cd45f
REPORT RequestId: c3cad570-49ad-11e8-8d97-27c7270cd45f  Duration: 1788.86 ms    Billed Duration: 1800 ms        Memory Size: 512 MB     Max Memory Used: 83 MB
[11:58:52 INF] Lambda result: {"Message": "Hello, ProjectBaseName", "$type": "SimpleFunctionResult"}
[11:58:52 INF] Exit: 0
```

The first time the function runs Lambda has to 'coldstart' so it takes longer to run. Run the function again, it should take less than 100 ms.

## Running Tests

Make sure your in root of the project, build the code and then run the tests

```ps
dotnet build .\ProjectBaseName.sln
dotnet test .\src\ProjectBaseName.Tests
Build started, please wait...
Build completed.

Test run for C:\dev\ProjectBaseName\ProjectBaseName\src\ProjectBaseName.Tests\bin\Debug\netcoreapp2.0\ProjectBaseName.Tests.dll(.NETCoreApp,Version=v2.0)
Microsoft (R) Test Execution Command Line Tool Version 15.3.0-preview-20170628-02
Copyright (c) Microsoft Corporation.  All rights reserved.

Starting test execution, please wait...
[xUnit.net 00:00:00.4834523]   Discovering: ProjectBaseName.Tests
[xUnit.net 00:00:00.5544326]   Discovered:  ProjectBaseName.Tests
[xUnit.net 00:00:00.5600989]   Starting:    ProjectBaseName.Tests
[xUnit.net 00:00:00.9062187]   Finished:    ProjectBaseName.Tests

Total tests: 1. Passed: 1. Failed: 0. Skipped: 0.
Test Run Successful.
Test execution time: 1.7203 Seconds
```