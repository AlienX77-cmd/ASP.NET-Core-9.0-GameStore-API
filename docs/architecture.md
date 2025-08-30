# GameStore API Architecture

## Overview

GameStore is a RESTful API built with ASP.NET Core Minimal APIs. It provides endpoints to manage video games and their genres in a game store database.

## System Architecture

### High-Level Architecture

```
┌─────────────┐         ┌─────────────┐         ┌─────────────┐
│             │         │             │         │             │
│   Clients   ├────────►│  GameStore  ├────────►│   SQLite    │
│             │         │     API     │         │  Database   │
│             │         │             │         │             │
└─────────────┘         └─────────────┘         └─────────────┘
```

### Components

- **Clients**: Web browsers, mobile apps, or any HTTP client
- **GameStore API**: ASP.NET Core Minimal API handling HTTP requests
- **SQLite Database**: Persistent storage for game and genre data

### Technology Stack

- **.NET 9.0**: Framework version
- **ASP.NET Core Minimal APIs**: Web API implementation
- **Entity Framework Core**: ORM for database operations
- **SQLite**: Database engine
- **MinimalApis.Extensions**: Extensions for minimal API validation

## Data Flow

1. Client sends HTTP request to an API endpoint
2. Endpoint handler processes the request
3. Data is validated (using MinimalApis.Extensions validation)
4. Entity Framework Core interacts with the SQLite database
5. Response is returned to the client

## API Endpoints

### Games Endpoints

- `GET /games`: Get all games
- `GET /games/{id}`: Get a specific game by ID
- `POST /games`: Create a new game
- `PUT /games/{id}`: Update an existing game
- `DELETE /games/{id}`: Delete a game

### Genres Endpoints

- `GET /genres`: Get all genres
