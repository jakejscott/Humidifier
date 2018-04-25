param(
  [parameter(position = 0, mandatory = $true)]
  [validateSet('$env')]
  [string] $_env,
  
  [parameter(position = 1, mandatory = $true)]
  [validateSet(
      'deploy-base',
      'deploy-simple',
      'invoke-simple',
      
      'secrets-encrypt',
      'secrets-decrypt',
      'secrets-upload'
    )]
  [string] $command
)

$project = "./src/ProjectBaseName.DeployTool/ProjectBaseName.DeployTool.csproj"
$cmd = "dotnet run --project $project $command --env=$_env --no-launch-profile"
Write-Host "$cmd" -ForegroundColor GREEN
Invoke-Expression $cmd