using TodoAPI.ViewModels;

namespace TodoAPI.Services;

public interface IAuthService
{
    Task Register(RegisterViewModel request);

    Task<string> Login(LoginViewModel request);
}
