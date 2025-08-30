# GameStore API File Details

## Core Files

### Program.cs

```csharp
// Entry point for the application
// Configures services, middleware, and endpoints
```

- Configures the SQLite database connection
- Registers endpoints for Games and Genres
- Handles database migration at startup
- Starts the application

### Data/GameStoreContext.cs

```csharp
// Entity Framework Core DbContext
```

- Defines database tables and relationships
- Configures the database connection
- Provides access to the database through DbSets for Games and Genres

### Data/DataExtensions.cs

```csharp
// Database extension methods
```

- Contains extension methods for database operations
- Includes migration utilities to set up and update the database schema

## Entity Models

### Entities/Game.cs

```csharp
// Game domain model
```

- Represents a video game in the system
- Contains properties like Id, Title, Price, ReleaseDate
- Has a relationship with Genre entity

### Entities/Genre.cs

```csharp
// Genre domain model
```

- Represents a game genre in the system
- Contains properties like Id and Name
- Has a one-to-many relationship with Game entity

## DTOs (Data Transfer Objects)

### Dtos/GameSummaryDto.cs

```csharp
// DTO for game summary information
```

- Used for list views with basic game information
- Contains essential properties like Id, Title, Price

### Dtos/GameDetailsDto.cs

```csharp
// DTO for detailed game information
```

- Used for detailed game information
- Includes all properties of a game including genre information

### Dtos/CreateGameDto.cs

```csharp
// DTO for creating new games
```

- Used when creating a new game
- Contains validation rules for game properties

### Dtos/UpdateGameDto.cs

```csharp
// DTO for updating existing games
```

- Used when updating an existing game
- Contains validation rules for game properties

### Dtos/GenreDto.cs

```csharp
// DTO for Genre entity
```

- Used for genre information
- Contains basic genre properties like Id and Name

## API Endpoints

### Endpoints/GamesEndpoints.cs

```csharp
// Defines API endpoints for Games
```

- GET /games - Get all games
- GET /games/{id} - Get a specific game
- POST /games - Create a new game
- PUT /games/{id} - Update a game
- DELETE /games/{id} - Delete a game
- Handles validation, database operations, and HTTP responses

### Endpoints/GenresEndpoint.cs

```csharp
// Defines API endpoints for Genres
```

- GET /genres - Get all genres

## Mapping

### Mapping/GameMapping.cs

```csharp
// Extension methods for mapping between Game entities and DTOs
```

- Contains methods to map Game entities to DTOs and vice versa
- Handles conversion between domain models and API contracts

### Mapping/GenreMapping.cs

```csharp
// Extension methods for mapping between Genre entities and DTOs
```

- Contains methods to map Genre entities to DTOs and vice versa
- Handles conversion between domain models and API contracts

## HTTP Test Files

### games.http

```
// HTTP request examples for testing Games endpoints
```

- Contains example HTTP requests for testing Games API endpoints
- Can be executed using the REST Client extension in VS Code

### genres.http

```
// HTTP request examples for testing Genres endpoints
```

- Contains example HTTP requests for testing Genres API endpoints
- Can be executed using the REST Client extension in VS Code

## Database Migrations

### Data/Migrations/

```csharp
// Contains EF Core database migrations
```

- `20250830124709_InitialCreate.cs`: Initial database schema creation
- `20250830131323_SeedGenres.cs`: Migration to seed initial genre data
- Each file represents a database schema change
- Used to create and update the database schema
