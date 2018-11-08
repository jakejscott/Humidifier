
$key = "$env:HUMIDIFIER_NUGET_API_KEY"

.\tools\nuget pack .\templates\Humidifier.Templates.nuspec -OutputDirectory .\templatepackages
.\tools\nuget push .\templatepackages\Humidifier.Templates.1.0.6.nupkg $key -src https://nuget.org