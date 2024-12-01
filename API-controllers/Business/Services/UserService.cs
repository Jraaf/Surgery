using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserService(IUserRepository _repo, IConfiguration _config) : IUserService
    {
        public async Task<UserDTO> Login(LoginUserDTO user)
        {
            var data = await _repo.GetByUsername(user.Username);
            if (data == null)
            {
                throw new NotFoundException($"There are no users with username {user.Username}");
            }
            using var hmac = new HMACSHA512(data.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.Password[i])
                    throw new Exception("WrongPassword");
            }
            return new UserDTO
            {
                Username = user.Username,
                AccessToken = CreateToken(user.Username)
            };
        }

        public async Task<UserDTO> Register(CreateUserDTO user)
        {
            if (await UserExists(user.Username))
            {
                throw new Exception("");
            }
            using var hmac = new HMACSHA512();

            var endUser = new User()
            {
                Username = user.Username,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PasswordSalt = hmac.Key
            };
            await _repo.AddAsync(endUser);

            return new UserDTO
            {
                Username = user.Username,
                DoctorId = user.DoctorId,
                AccessToken = CreateToken(user.Username)
            };
        }

        public async Task<bool> UserExists(string username)
        {
            return await _repo.UserExists(username);
        }

        public string CreateToken(string username)
        {
            var tokenKey = _config["TokenKey"] ?? throw new Exception("cannot access token key");
            if (tokenKey.Length < 64) throw new Exception("too short key");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

            var claims = new List<Claim>
        {
            new (ClaimTypes.NameIdentifier,username)
        };

            var credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddDays(1),
                SigningCredentials = credentials
            };

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
