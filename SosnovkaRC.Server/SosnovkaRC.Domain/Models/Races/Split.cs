namespace SosnovkaRC.Domain.Models.Races;

public class Split : Entity
{
    public Result Result { get; set; } = null!;
    public int ResultId { get; set; }

    public TimeSpan SplitTime { get; set; }
    public double SplitDistance { get; set; }
}