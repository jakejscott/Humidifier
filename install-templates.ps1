# To clear out custom templates you can run
# dotnet new --debug:reinit

Write-Host "Packaging templates..."
tools\nuget pack .\templates\Humidifier.Templates.nuspec -OutputDirectory .\templatepackages

Write-Host "Uninstalling templates..."
dotnet new -u .\templatepackages

Write-Host "Installing templates..."
dotnet new -i .\templatepackages

