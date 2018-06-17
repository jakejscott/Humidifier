dotnet restore "src/Humidifier.sln"
dotnet build "src/Humidifier.sln"
$env:BUILD_PATH = $PWD
dotnet ./src/Humidifier.CodeGen/bin/Debug/netcoreapp2.0/Humidifier.CodeGen.dll