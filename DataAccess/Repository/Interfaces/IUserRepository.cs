using DataAccess.Entities;
using DataAccess.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository.Interfaces
{
    public interface IUserRepository : IRepo<User, int>
    {
        Task<bool> UserExists(string username);
        Task<User> GetByUsername(string username);
    }
}
