# HikersApp
this a technical interview for a semi senior position developer
Usefull commands

This command is for creating a reference between two projects 
```bash
dotnet add reference project_path
```

This command is for adding new package from nuget repository to the project
```bash
dotnet add package package_name
```


# Migrations manage
## Notes: don't forget run this command from webApi project and create the database

Make migration to database

```sh
cd src/WebApi && dotnet ef migrations add --project ../Infrastructure/ migration_name
```

Update database

```sh
cd src/WebApi && dotnet ef database update -p ../Infrastructure/
```

Build the project and run it

```sh
cd src/WebApi
```

Build the project

```sh
cd src/WebApi && dotnet build
```

Run the project

```sh
cd src/WebApi && dotnet run
```