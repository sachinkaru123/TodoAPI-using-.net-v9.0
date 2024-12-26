# Todo App

A simple Todo app built with .NET 9.0, providing CRUD operations (Create, Read, Update, Delete) for managing tasks. This app uses Entity Framework Core for database interactions and Swagger for API documentation.

---

## Features

- Add, view, update, and delete tasks.
- API documentation and testing via Swagger UI.
- Supports MySQL as the database provider.

---

## Prerequisites

Before running the project, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download)
- [MySQL Server](https://dev.mysql.com/downloads/)
- Any IDE with .NET support (e.g., Visual Studio, Visual Studio Code)

---

## Technologies Used

### NuGet Packages

The following NuGet packages are used in the project:

1. **Entity Framework Core**: 
   - `Microsoft.EntityFrameworkCore` - Core ORM.
   - `Microsoft.EntityFrameworkCore.Design` - Tools for EF migrations.
   - `Pomelo.EntityFrameworkCore.MySql` - MySQL database provider.

   ```bash
   dotnet add package Microsoft.EntityFrameworkCore --version 8.0.2
   dotnet add package Microsoft.EntityFrameworkCore.Design --version 8.0.2
   dotnet add package Pomelo.EntityFrameworkCore.MySql


## API Documentation

For API testing and documentation, we have included a Postman collection. You can import this collection into Postman to test the API endpoints.

### Import Postman Collection

1. Open Postman.
2. Go to `File > Import`.
3. Choose the file: [`TodoAppC#.postman_collection.json`](./Postman Collection/TodoAppC#.postman_collection.json).

The collection includes:
- Predefined API requests.
