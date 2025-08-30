# GameStore API Documentation

Welcome to the GameStore API documentation. This comprehensive guide provides information about the system architecture, project structure, and implementation details of the GameStore API.

## Table of Contents

1. [System Architecture](architecture.md)

   - Overview
   - High-Level Architecture
   - Components
   - Technology Stack
   - Data Flow
   - API Endpoints

2. [Project Structure](project-structure.md)

   - Folder Structure
   - Key Files and Their Purposes
   - Configuration Files

3. [File Details](file-details.md)
   - Core Files
   - Entity Models
   - DTOs (Data Transfer Objects)
   - API Endpoints
   - Mapping
   - HTTP Test Files
   - Database Migrations

## Getting Started

To run this project locally:

1. Clone the repository
2. Navigate to the project directory: `cd GameStore.API`
3. Run the application: `dotnet run`
4. The API will be available at `https://localhost:5001` and `http://localhost:5000`

## API Testing

You can test the API endpoints using the provided `.http` files:

- `games.http`: Test game-related endpoints
- `genres.http`: Test genre-related endpoints

These files can be executed using the REST Client extension in Visual Studio Code.

## Database

The application uses SQLite as the database engine. The database file is located at `GameStore.API/GameStore.db`.

Database migrations are handled automatically when the application starts, but you can also run them manually:

```bash
dotnet ef database update
```

To create a new migration:

```bash
dotnet ef migrations add MigrationName --output-dir Data\Migrations
```
