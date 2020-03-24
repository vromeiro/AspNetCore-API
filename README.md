# ASP.NET Core Web API

Web API template that uses ASP.NET Core CLI, dotnet SDK v2.2.106, Swagger, MySQL, Dapper.

## Running through terminal
- dotnet watch run
- Listening on: http://localhost:5001
- Swagger on: http://localhost:5001/swagger

## Project setup
### CLI commands
- dotnet new sln
- dotnet new webapi
- dotnet sln add aspnetcore-api.csproj
- dotnet add package MySqlConnector
- dotnet add package Swashbuckle.AspNetCore
- dotnet add package Dappers
