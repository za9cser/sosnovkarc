using SosnovkaRC.Domain.Models.Athletes;
using SosnovkaRC.Repository.Repositories;

namespace SosnovkaRC.BusinessLogic.Services;

public interface IAthletesService
{
    Task<Athlete[]> GetAthletesAsync();
}

public class AthletesService : IAthletesService
{
    private readonly IRepository<Athlete> _athleteRepository;

    public AthletesService(IRepository<Athlete> athleteRepository)
    {
        _athleteRepository = athleteRepository;
    }

    public async Task<Athlete[]> GetAthletesAsync() => await _athleteRepository.GetAsync();
}