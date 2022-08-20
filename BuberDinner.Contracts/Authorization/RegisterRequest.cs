namespace BuberDinner.Contracts.Authorization;

public record RegisterRequest(
    string FirstName,
    string LastName,
    string Email,
    string Password);

