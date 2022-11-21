using Microsoft.AspNetCore.Mvc;

namespace SosnovkaRC.ServerApi.Controllers;

[ApiController]
public class AthletesController : Controller
{

    public AthletesController()
    {
        
    }


    [HttpGet("[controller]")]
    public IActionResult GetAll([FromQuery] bool includeLeaved = false)
    {
        return Ok();
    }

    [HttpGet("[controller]/{id}")]
    public IActionResult Get(int id)
    {
        return Ok();
    }



}