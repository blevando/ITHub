using System.IdentityModel.Tokens.Jwt;
using ITHub.Models.Dto;

namespace ITHub.Services.Interfaces
{
    public interface IAuthenticationManagement
    {
        Task<string> Register(RegisterRequestDto request);
        Task<string> RegisterAdmin(RegisterRequestDto request);
        Task<string> Login(LoginRequestDto request);
        Task<string> ChangePassword(ChangePasswordRequestDto request);
    }
}

