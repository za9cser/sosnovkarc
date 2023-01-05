using Microsoft.AspNetCore.Mvc;
using SosnovkaRC.BusinessLogic.Services;

namespace SosnovkaRC.ServerApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AthletesController : Controller
{
    private readonly IAthletesService _athletesService;

    public AthletesController(IAthletesService athletesService)
    {
        _athletesService = athletesService;
    }

    [HttpGet("[controller]")]
    public async Task<IActionResult> GetAllAsync([FromQuery] bool includeLeaved = false)
    {
        var athletes = await _athletesService.GetAthletesAsync();
        return Ok(athletes);
    }

    [HttpGet("[controller]/{id}")]
    public IActionResult Get(int id)
    {
        return Ok();
    }
}