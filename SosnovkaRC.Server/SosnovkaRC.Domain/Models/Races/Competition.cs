namespace SosnovkaRC.Domain.Models.Races;

public class Competition : Entity
{
    public string Name { get; set; } = null!;
    public string CityId { get; set; } = null!;
    public string CityName { get; set; } = null!;

    public List<Race>? Races { get; set; }
}