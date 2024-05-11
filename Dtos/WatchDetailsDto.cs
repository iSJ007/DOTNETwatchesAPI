
namespace watchesASP.Api.Dtos
{
    public record class WatchDetailsDto(
        int Id,
        string Name,
        int MovTypeId,
        decimal Price,
        string Style,
        string WaterResist,
        DateOnly ReleaseDate);
}