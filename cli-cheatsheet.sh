#[vscode] baixar C# dev kit
#comandos CLI dotnet
dotnet --info
dotnet --help
dotnet --version
dotnet new list
dotnet new template -o NomeProjeto
    dotnet new webapi --use-controllers -o WebApi
dotnet build
dotnet run
dotnet test
dotnet publish
dotnet restore
dotnet pack
dotnet add package
    dotnet add package NSwag.AspNetCore
dotnet remove package
dotnet list package

dotnet tool install --global dotnet-ef
dotnet ef migrations add MigracaoInicial
dotnet ef migrations remove MigracaoInicial
dotnet ef database update