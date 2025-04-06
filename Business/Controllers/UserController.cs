using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    [HttpGet("GetUser")]
    public IActionResult GetUser()
    {
        return Ok(new { message = "User was returned" });
    }

    [HttpPost("CreateUser")]
    public IActionResult CreateUser()
    {
        return Ok(new { message = "User created" });
    }
}