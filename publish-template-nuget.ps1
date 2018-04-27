
$key = "$env:HUMIDIFIER_NUGET_API_KEY"

nuget push .\templates\Humidifier.Templates.1.0.0.nupkg -ApiKey $key -Source https://nuget.org