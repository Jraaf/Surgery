using AutoMapper;
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
    public class UserService(IUserRepository _repo, IConfiguration _config,IMapper _mapper) : IUserService
    {
        public async Task<UserDTO> Login(LoginUserDTO dto)
        {
            var user = await _repo.GetByUsername(dto.Username);

            if (user == null)
            {
                throw new NotFoundException(dto.Username);
            }

            var hmac = new HMACSHA512(user.PasswordSalt);

            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.Password[i])
                    throw new Exception("Wrong password");
            }
            var endUser = new UserDTO()
            {
                Id = user.Id,
                Username = user.Username,
                AccessToken = CreateToken(user),
            };
            return endUser;
        }

        public async Task<UserDTO> Register(CreateUserDTO dto)
        {
            if (await _repo.UserExists(dto.Username))
            {
                throw new Exception($"{dto.Username} already taken");
            }

            using var hmac = new HMACSHA512();

            User user = new User()
            {
                Username = dto.Username,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(dto.Password)),
                PasswordSalt = hmac.Key
            };

            var endUser = _mapper.Map<UserDTO>(await _repo.AddAsync(user));

            endUser.AccessToken = CreateToken(user);
            return endUser;
        }

        public string CreateToken(User dto)
        {
            var tokenKey = _config["TokenKey"] ?? throw new Exception("cannot access token key");
            if (tokenKey.Length < 64) throw new Exception("too short key");

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(tokenKey));

            var claims = new List<Claim>
        {
            new (ClaimTypes.NameIdentifier, dto.Id.ToString())
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

        public async Task<bool> UserExists(string username)
        {
            return await _repo.UserExists(username);
        }     
    }
}
