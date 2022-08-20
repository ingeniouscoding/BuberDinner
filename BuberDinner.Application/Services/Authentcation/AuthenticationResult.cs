namespace BuberDinner.Application.Services.Authentcation;

public record AuthenticationResult(
    Guid Id,
    string FirstName,
    string LastName,
    string Email,
    string Token);

