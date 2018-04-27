param(
  [parameter(position = 0, mandatory = $true)]
  [validateSet('$env$')]
  [string] $env,
  
  [parameter(position = 1, mandatory = $true)]
  [validateSet(
      'deploy-base',
      'deploy-simple',
      'invoke-simple',
      'tests',
      'secrets-encrypt',
      'secrets-decrypt',
      'secrets-upload',
      'destroy-simple',
      'destroy-base'
    )]
  [string] $command
)

if ($command -eq "tests") {
  dotnet test .\src\ProjectBaseName.Tests
} else {
  $project = ".\src\ProjectBaseName.DeployTool\ProjectBaseName.DeployTool.csproj"
  $cmd = "dotnet run --project $project $command --env=$env$ --no-launch-profile"
  Write-Host "$cmd" -ForegroundColor GREEN
  Invoke-Expression $cmd
}