$projectName = "ExampleProject"
$stack = "example"
$env = "test"
$region = "us-west-2"
$profile = "example"
$build_config = "Debug"
$team = "example"
$email = "example@example.com"

Remove-Item $projectName -ErrorAction Ignore -Force -Recurse

dotnet new humidifier.sln --name $projectName --output $projectName --env $env --region $region --stack $stack --profile $profile --build_config $build_config --team $team --email $email
# dotnet new humidifier.sln --name $projectName --output $projectName


