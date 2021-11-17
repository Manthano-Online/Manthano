# Manthano

## EF Core

_From terminal_

* open project path of Manthano.Persistence
* ensure 'Microsoft.EntityFrameworkCore.Tools' is installed via `Install-Package Microsoft.EntityFrameworkCore.Tools`
* ensure dotnet-ef is up to date with `dotnet tool update --global dotnet-ef --version 6.0.0`
* add migration like so `dotnet ef migrations add Initial -o Data/Migrations -s ..\Manthano.Api\`
* alternatively cd into the Manthano.Api project and run `dotnet ef migrations add Initial -o Data/Migrations -s ..\Persistence\`