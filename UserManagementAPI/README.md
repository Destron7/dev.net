# TechHive User Management API

A robust ASP.NET Core Web API for managing user records, built with modern .NET technologies. This API provides full CRUD operations for users, including validation, authentication, logging, and error handling middleware.

## Features

- **CRUD Operations**: Create, read, update, and delete user records.
- **Data Validation**: Ensures valid user input with required fields and email validation.
- **Authentication**: Token-based authentication middleware for secure access.
- **Logging**: Comprehensive request/response logging for auditing.
- **Error Handling**: Consistent JSON error responses for unhandled exceptions.
- **Swagger Documentation**: Interactive API documentation.

## Technologies Used

- ASP.NET Core 8.0
- C# with nullable reference types
- Custom middleware for cross-cutting concerns
- In-memory data storage (easily replaceable with a database)

## Getting Started

1. Ensure .NET 8.0 SDK is installed.
2. Clone the repository and navigate to the `UserManagementAPI` folder.
3. Run `dotnet build` to build the project.
4. Run `dotnet run` to start the API.
5. Access Swagger UI at `http://localhost:5000/swagger` for testing.

## API Endpoints

- `GET /api/users` - Retrieve all users
- `GET /api/users/{id}` - Retrieve a user by ID
- `POST /api/users` - Create a new user
- `PUT /api/users/{id}` - Update an existing user
- `DELETE /api/users/{id}` - Delete a user by ID

Use `Authorization: Bearer valid-token` header for authenticated requests.

## Project Structure

- `Controllers/` - API controllers
- `Models/` - Data models
- `Middleware/` - Custom middleware components
- `Program.cs` - Application entry point and configuration