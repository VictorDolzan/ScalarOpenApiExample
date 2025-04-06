using Business.Models;
using Business.Models.Scalar;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
[SwaggerTag("🗃️Handles department-related actions like get departments.")]
public class DepartmentController : ControllerBase
{
    [HttpGet("GetDepartment")]
    [SwaggerOperation(
        Summary = "Get Department",
        Description = "Retrieves a department from the system.",
        OperationId = "GetDepartment"
    )]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetDepartment()
    {
        return Ok(new { message = "Department returned" });
    }

    [HttpPost("CreateDepartment")]
    [SwaggerOperation(
        Summary = "Create Department",
        Description = "Creates a new department in the system.",
        OperationId = "CreateDepartment"
    )]
    [SwaggerRequestExample(typeof(DepartmentRequest), typeof(DepartmentRequestExample))]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateDepartment(DepartmentRequest departmentRequest)
    {
        return Ok(new { message = "Department created" });
    }
}