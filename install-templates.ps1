# To clear out custom templates you can run
# dotnet new --debug:reinit

Write-Host "Packaging templates..."
tools\nuget pack .\templates\Humidifier.Templates.nuspec -OutputDirectory .\templates

Write-Host "Uninstalling templates..."
dotnet new -u .\templates

Write-Host "Installing templates..."
dotnet new -i .\templates

