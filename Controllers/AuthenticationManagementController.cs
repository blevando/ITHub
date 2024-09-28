using ITHub.Managers;
using ITHub.Models.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ITHub.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationManagementController : ControllerBase
    {

        private readonly AuthenticationManager _manager;

        public AuthenticationManagementController(AuthenticationManager manager)
        {
            _manager = manager;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<string> Register(RegisterRequestDto request)
        {
            return await _manager.Register(request);
        }

        [HttpPost]
        [Route("RegisterAdmin")]
        public async Task<string> RegisterAdmin(RegisterRequestDto request)
        {
            return await _manager.RegisterAdmin(request);
        }

        [HttpPost]
        [Route("Login")]
        public async Task<string> Login(LoginRequestDto request)
        {
            return await _manager.Login(request);
        }

        [HttpPut]
        [Route("ChangePassword")]
        public async Task<string> ChangePassword(ChangePasswordRequestDto request)
        {
            return await _manager.ChangePassword(request);
        }
    }
}
