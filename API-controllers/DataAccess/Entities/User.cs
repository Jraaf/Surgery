using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public required byte[] Password { get; set; }
        public required byte[] PasswordSalt { get; set; }
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
