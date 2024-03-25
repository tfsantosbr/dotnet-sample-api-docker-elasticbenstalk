using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
    [HttpGet]
    public IActionResult Index()
    {
        return Ok("Hello World!!!");
    }

    [HttpGet("secure")]
    [Authorize]
    public IActionResult Secure()
    {
        return Ok("You are allowed!!!");
    }
}
