
$key = "$env:HUMIDIFIER_NUGET_API_KEY"

.\tools\nuget pack .\templates\Humidifier.Templates.nuspec -OutputDirectory .\templates
.\tools\nuget push .\templates\Humidifier.Templates.1.0.1.nupkg $key -src https://nuget.org