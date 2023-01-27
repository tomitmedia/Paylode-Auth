using Microsoft.AspNetCore.Identity;
using WeatherAuth.Models;

namespace WeatherAuth.Interfaces
{
    public interface IAccountRepo
    {
        Task<IdentityResult> RegisterAsync(RegisterModel registerModel);
        Task<string> LoginAsync(LoginModel loginModel);

    }
}
