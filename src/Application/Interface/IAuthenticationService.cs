namespace Application;

public interface IAuthenticationService
{
    Task<string> RegisterAsync(RegisterRequest registerRequest);
    Task<string> LoginAsync(LoginRequest loginRequest);
}
