using SosnovkaRC.Domain.Models.Platforms;

namespace SosnovkaRC.Domain.Models.Athletes;

public class AthleteIdentifier : Entity
{
    public Athlete? Athlete { get; set; }
    public int AthleteId { get; set; }
    public string Identifier { get; set; } = null!;
    public Platform? Platform { get; set; }
    public int PlatformId { get; set; }
}