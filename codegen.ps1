dotnet restore "src/Humidifier.sln"
dotnet build "src/Humidifier.sln"
$env:BUILD_PATH = $PWD
dotnet ./src/Humidifier.CodeGen/bin/Debug/netcoreapp1.1/Humidifier.CodeGen.dll