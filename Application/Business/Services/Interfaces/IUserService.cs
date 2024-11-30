using Business.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface IUserService
    {
        Task<bool> UserExists(string username);
        Task<UserDTO> Register(CreateUserDTO user);
        Task<UserDTO> Login(LoginUserDTO user);
        string CreateToken(string username);
    }
}
