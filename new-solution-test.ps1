$projectName = "TestProject"

Remove-Item $projectName -ErrorAction Ignore -Recurse

dotnet new humidifier.sln --name $projectName --output $projectName --force
