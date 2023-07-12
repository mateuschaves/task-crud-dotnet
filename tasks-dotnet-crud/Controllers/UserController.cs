using Microsoft.AspNetCore.Mvc;
using tasks_dotnet_crud.Models;

namespace tasks_dotnet_crud.Controllers;

[ApiController]
[Route("api/user")]
public class UserController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new UserModel
        {
            Id = 1,
            Name = "John Doe",
            Email = "mateus@gmail.com",
        });
    }
}