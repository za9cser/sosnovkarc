using System.ComponentModel.DataAnnotations;

namespace SosnovkaRC.Domain.Models.Races;

public class Race : Entity
{
    public Competition Competition { get; set; } = null!;
    public int CompetitionId { get; set; }

    [MaxLength(100)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    public string Description { get; set; } = null!;

    public DateTime Date { get; set; }

    public List<Run>? Runs { get; set; }
}