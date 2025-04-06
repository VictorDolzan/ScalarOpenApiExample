using Business.Models;
using Business.Models.Scalar;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.Filters;

namespace Business.Controllers;

[ApiController]
[Route("api/[controller]")]
[SwaggerTag("👨🏻‍🚀Handles user-related actions like create user, get user and user deletion.")]
public class UserController : ControllerBase
{
    [HttpGet("GetUser")]
    [SwaggerOperation(
        Summary = "Get User",
        Description = "Retrieves a user from the system.",
        OperationId = "GetUser"
    )]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetUser()
    {
        return Ok(new { message = "User was returned" });
    }

    [HttpPost("CreateUser")]
    [SwaggerOperation(
        Summary = "Create User",
        Description = "Creates a new user in the system.",
        OperationId = "CreateUser"
    )]
    [SwaggerRequestExample(typeof(UserRequest), typeof(UserRequestExample))]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CreateUser([FromBody] UserRequest userRequest)
    {
        return Ok(new { message = "User created" });
    }
    
    [HttpDelete("DeleteUser")]
    [SwaggerOperation(
        Summary = "Delete User",
        Description = "Deletes a user from the system.",
        OperationId = "DeleteUser"
    )]
    [SwaggerRequestExample(typeof(DeleteUserRequest), typeof(DeleteUserRequestExample))]
    [ProducesResponseType(typeof(object), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult DeleteUser([FromBody] DeleteUserRequest request)
    {
        return Ok(new { message = "User deleted!" });
    }
}