using GameStore.Api.Entities;
using GameStore.API.Dtos;

namespace GameStore.API.Mapping;

public static class GenreMapping
{
    public static GenreDto ToDto(this Genre genre)
    {
        return new GenreDto(genre.Id, genre.Name);
    }
}
