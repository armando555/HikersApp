# HikersApp

this a technical interview for a semi senior position developer
In this case de frontend was made in Express using html, javascript(Ajax), and CSS [VANILA PROJECT] and the Web Api was built in Dotnet 7 using a DDD(Domain driven design) and implementing a endpoint

# Migrations manage

## Notes: don't forget run this command from webApi project and create the database

Make migration to database

```sh
cd src/WebApi && dotnet ef migrations add --project ../Infrastructure/ third_migration
```

Update database

```sh
cd src/WebApi && dotnet ef database update -p ../Infrastructure/
```

Build the project

```sh
cd src/WebApi && dotnet build
```

Run the project

```sh
cd src/WebApi && dotnet run
```

# Run the frontend

install dependencies of express

```sh
cd frontend && npm i
```

Run the project

```sh
cd frontend && npm start
```