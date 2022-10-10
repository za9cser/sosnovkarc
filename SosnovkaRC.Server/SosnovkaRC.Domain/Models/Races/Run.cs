using System.ComponentModel.DataAnnotations;

namespace SosnovkaRC.Domain.Models.Races;

public class Run : Entity
{
    public Race Race { get; set; } = null!;
    public int RaceId { get; set; }

    [MaxLength(100)]
    public string? Name { get; set; }

    public double Distance { get; set; }
    public TimeSpan Duration { get; set; }

    public bool IsDistanceRun { get; set; }

    public bool IsOutdoor { get; set; } = true;

    public List<Result> Results { get; set; } = new(0);

    // TODO: dial with "named" distances: mile, two miles
}