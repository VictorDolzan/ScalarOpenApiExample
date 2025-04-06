using Microsoft.AspNetCore.Mvc;
namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthenticationController : ControllerBase
{
    [HttpGet("Login")]
    public IActionResult Login()
    {
        return Ok(new { message = "Login" });
    }

    [HttpPost("HealthCheck")]
    public IActionResult HealthCheck()
    {
        return Ok(new { message = "Health checked!" });
    }
}