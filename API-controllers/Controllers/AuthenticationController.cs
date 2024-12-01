using Business.DTO;
using Business.Services;
using Business.Services.Interfaces;
using DataAccess.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

namespace API_controllers.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenticationController(IUserService _service) : ControllerBase
    {
        [HttpPost("register")]
        public async Task<ActionResult<UserDTO>> Register(CreateUserDTO dto)
        {
            try
            {
                return Ok(await _service.Register(dto));
            }
            catch (Exception e)
            {
                return Unauthorized(e.Message);
            }
        }
        [HttpPost("login")]
        public async Task<ActionResult<UserDTO>> Login(LoginUserDTO dto)
        {
            try
            {
                return Ok(await _service.Login(dto));
            }
            catch (Exception e)
            {
                return Unauthorized(e.Message);
            }
        }
    }
}
