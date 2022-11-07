
https://learn.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli


Paket Manager Console:
cd "C:\Users\Viktor\source\repos\Seminare Sourcen\jarai.csharp.basics\EntityFramework.Core.CodeFirst"
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update

