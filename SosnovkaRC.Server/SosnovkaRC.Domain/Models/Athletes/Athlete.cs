using SosnovkaRC.Domain.Models.Races;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SosnovkaRC.Domain.Models.Athletes;

[Table("Athletes")]
public class Athlete : Entity
{
    [MaxLength(100)]
    [Required]
    public string FirstName { get; set; } = null!;

    [MaxLength(100)]
    [Required]
    public string LastName { get; set; } = null!;

    public DateTime DoB { get; set; }
    public DateTime JoiningDate { get; set; }
    public DateTime? LeavingDate { get; set; }
    public string? Bio { get; set; }
    public List<Result> Results { get; set; } = new(0);
    public List<AthleteIdentifier> Identifiers { get; set; } = new(0);
}