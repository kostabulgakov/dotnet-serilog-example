# dotnet-serilog-example

## Commands
``` bash
dotnet new console -n SerilogTestApp
cd SerilogTestApp
dotnet add package Serilog
dotnet add package Serilog.Sinks.Console

dotnet build
dotnet run --project ./SerilogTestApp/SerilogTestApp.csproj

dotnet publish --configuration Release --output ./publish
dotnet publish --configuration Release --output ./publish_self_contained --self-contained --runtime linux-x64
```