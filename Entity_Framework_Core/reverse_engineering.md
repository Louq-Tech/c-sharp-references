# Reverse engineering is the process of generating entity type classes and a DbContext class based on an existing database schema.

This reference is based on PostgreSQL RDBMS only

## Tools needed
Either use PMC or .NET CLI

### PMC
`Install-Package Microsoft.EntityFrameworkCore.Tools`

### .NET CLI
`dotnet tool install --global dotnet-ef`

### NuGet package needed
`Microsoft.EntityFrameworkCore.Design`

## Database provider installation
### PMC
`Install-Package Npgsql.EntityFrameworkCore.PostgreSQL -Version 8.0.0`
### .NET CLI
`dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL --version 8.0.0`

## Reverse Engineering Connection String
### PMC
`Scaffold-DbContext 'Host=my_host;Database=my_db;Username=my_user;Password=my_pw' Npgsql.EntityFrameworkCore.PostgreSQL -OutputDir Models`
### .NET CLI
`dotnet ef dbcontext scaffold "Host=my_host;Database=my_db;Username=my_user;Password=my_pw" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir Models`

# Sources
[Microsoft Official Documentation - Scaffold](https://learn.microsoft.com/en-us/ef/core/managing-schemas/scaffolding/?tabs=dotnet-core-cli)
