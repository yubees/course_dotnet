
using Course.Contracts.course;
using Course.Model;
using Microsoft.AspNetCore.Mvc;

namespace Course.Conroller;

[ApiController]
[Route("[controller]")]
public class AuthController : ControllerBase
{
    [HttpPost("/register")]

    public IActionResult Register(RegisterResponse request)
    {

        var user = new User(
            request.Name,
            request.Email,
            request.Password
        );


        var response = new RegisterResponse(
            user.Email,
            user.Name,
            user.Password
        );
        return CreatedAtAction(
            actionName: nameof(LoginResponse),
            response);
    }

    [HttpPost("/login")]

    public IActionResult Login(LoginResponse request)
    {

        return Ok(request);
    }
}