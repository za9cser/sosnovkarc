namespace SosnovkaRC.Domain.Models.Races;

public class Result : Entity
{
    public Run Run { get; set; } = null!;
    public int RunId { get; set; }

    public TimeSpan FinishTime { get; set; }
    public double FinishDistance { get; set; }

    public List<Split> Splits { get; set; } = new(0);
}