using Microsoft.AspNetCore.Mvc;
using SosnovkaRC.BusinessLogic.Services;

namespace SosnovkaRC.ServerApi.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class UtilsController : Controller
{
    private readonly IAthletesUtilsService _athletesUtilsService;

    public UtilsController(IAthletesUtilsService athletesUtilsService)
    {
        _athletesUtilsService = athletesUtilsService;
    }

    [HttpGet]
    public async Task<IActionResult> InitAthletesFromFile()
    {
        return Ok(await _athletesUtilsService.InitFromFile());
    }
}