using BuberDinner.Application.Services.Authentcation;
using BuberDinner.Contracts.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers;
[Route("auth")]
[ApiController]
public class AuthenticationController : ControllerBase
{
    public AuthenticationController(IAuthenticationService authenticationService)
    {
        this.authenticationService = authenticationService;
    }

    private readonly IAuthenticationService authenticationService;

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        var authResult = authenticationService.Register(
            request.FirstName,
            request.LastName,
            request.Email,
            request.Password);

        AuthenticationResponse response = new(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token);
        return Ok(response);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        var authResult = authenticationService.Login(request.Email, request.Password);

        AuthenticationResponse response = new(
            authResult.Id,
            authResult.FirstName,
            authResult.LastName,
            authResult.Email,
            authResult.Token);
        return Ok(response);
    }
}
