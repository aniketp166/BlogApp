using Application;
using Microsoft.AspNetCore.Mvc;

namespace API;

public class AuthController(IAuthenticationService authenticationService) : BaseApiController
{
    [HttpPost("register")]
    public async Task<IResult> Register(RegisterRequest registerRequest)
    {
        var response = await authenticationService.RegisterAsync(registerRequest);
        return Results.Ok(response);
    }
    [HttpPost("login")]
    public async Task<IResult> Login(LoginRequest loginRequest)
    {
        return Results.Ok();
    }
}
