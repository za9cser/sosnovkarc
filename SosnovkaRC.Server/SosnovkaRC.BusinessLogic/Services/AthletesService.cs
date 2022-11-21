using SosnovkaRC.Domain.Models.Athletes;

namespace SosnovkaRC.BusinessLogic.Services;

public interface IAthletesService
{
    Athlete[] InitFromFile();
}

public class AthletesService
{
}