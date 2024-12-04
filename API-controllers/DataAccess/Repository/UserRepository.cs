using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository
{
    public class UserRepository : Repo<User, int>, IUserRepository
    {
        private readonly OperationsDepartmentContext _context;
        public UserRepository(OperationsDepartmentContext context)
            : base(context)
        {
            _context = context;
        }
           
        public async Task<User> GetByUsername(string username)
        {
            return await _context.Users.FirstOrDefaultAsync(x =>
                         x.Username.ToLower() == username.ToLower());
        }

        public async Task<bool> UserExists(string username)
        {
            return await _context.Users.AnyAsync(x =>
                x.Username.ToLower() == username.ToLower());
        }
    }
}
