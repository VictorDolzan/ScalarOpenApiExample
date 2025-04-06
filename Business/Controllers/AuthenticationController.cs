using Business.Models;
using Business.Models.Scalar;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
[SwaggerTag("💉Handles authentication-related actions like login and health checks.")]
public class AuthenticationController : ControllerBase
{
    [HttpPost("Login")]
    [SwaggerOperation(
        Summary = "Login",
        Description = "Logs in the user and returns a success message.",
        OperationId = "Login"
    )]
    [SwaggerRequestExample(typeof(LoginRequest), typeof(LoginRequestExample))]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Login([FromBody] LoginRequest request)
    {
        return Ok(new { message = "Login" });
    }

    [HttpGet("HealthCheck")]
    [SwaggerOperation(
        Summary = "Check Health",
        Description = "🩺Checks the health of the service",
        OperationId = "HealthCheck"
    )]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status500InternalServerError)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult HealthCheck()
    {
        return Ok(new { message = "Health checked!" });
    }
}