using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SampleApi.Controllers;

[ApiController]
[Route("users")]
public class UsersController : ControllerBase
{
    [HttpGet]
    [Authorize]
    public IActionResult GetUsers()
    {
        return Ok("GET Users");
    }

    [HttpPost]
    [Authorize(Roles = "CreateUser")]
    public IActionResult CreateUser()
    {
        return Ok("Create User");
    }

    [HttpPut]
    [Authorize(Roles = "UpdateUser")]
    public IActionResult UpdateUser()
    {
        return Ok("Update User");
    }

    [HttpDelete]
    [Authorize(Roles = "RemoveUser")]
    public IActionResult RemoveUser()
    {
        return Ok("Remove User");
    }
}
