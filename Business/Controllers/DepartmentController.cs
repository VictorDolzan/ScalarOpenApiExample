using Microsoft.AspNetCore.Mvc;

namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DepartmentController : ControllerBase
{
    [HttpGet("GetDepartment")]
    public IActionResult GetDepartment()
    {
        return Ok(new { message = "Department returned" });
    }

    [HttpPost("CreateDepartment")]
    public IActionResult CreateDepartment()
    {
        return Ok(new { message = "Department created" });
    }
}