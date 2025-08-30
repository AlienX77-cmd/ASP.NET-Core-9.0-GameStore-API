# GameStore Project Structure

## Folder Structure

```
GameStore.API/
├── Data/
│   ├── DataExtensions.cs     # Database extension methods
│   ├── GameStoreContext.cs   # EF Core database context
│   └── Migrations/           # EF Core database migrations
├── Dtos/
│   ├── CreateGameDto.cs      # DTO for creating games
│   ├── GameDetailsDto.cs     # DTO for game details
│   ├── GameSummaryDto.cs     # DTO for game summary
│   ├── GenreDto.cs           # DTO for genres
│   └── UpdateGameDto.cs      # DTO for updating games
├── Endpoints/
│   ├── GamesEndpoints.cs     # Games API endpoint definitions
│   └── GenresEndpoint.cs     # Genres API endpoint definitions
├── Entities/
│   ├── Game.cs               # Game entity model
│   └── Genre.cs              # Genre entity model
├── Mapping/
│   ├── GameMapping.cs        # Game entity to DTO mapping
│   └── GenreMapping.cs       # Genre entity to DTO mapping
├── Properties/
│   └── launchSettings.json   # Application launch settings
├── appsettings.json          # Application configuration
├── appsettings.Development.json  # Development configuration
├── games.http                # HTTP request examples for games endpoints
├── genres.http               # HTTP request examples for genres endpoints
├── Program.cs                # Application entry point
└── GameStore.API.csproj      # Project file
```

## Key Files and Their Purposes

### Program.cs

Entry point for the application. Configures the application's services, middleware, and endpoints.

### Data/GameStoreContext.cs

Entity Framework Core DbContext that defines the database schema and provides access to the database.

### Data/DataExtensions.cs

Contains extension methods for database operations, including migrations.

### Entities/Game.cs & Genre.cs

Domain models representing the core business entities of the application.

### Dtos/\*.cs

Data Transfer Objects that define the shape of data exchanged with clients.

### Endpoints/\*.cs

Minimal API endpoint definitions that handle HTTP requests and responses.

### Mapping/\*.cs

Extension methods that map between domain entities and DTOs.

## Configuration Files

### appsettings.json

Contains application-wide settings, including connection strings and logging configuration.

### appsettings.Development.json

Development-specific settings that override the main appsettings.json for development environments.

### Properties/launchSettings.json

Defines how the application is launched during development.

### \*.http Files

HTTP request files for testing the API endpoints using the REST Client extension in VS Code.

## Project File

### GameStore.API.csproj

The project file containing references to NuGet packages and project configuration.
