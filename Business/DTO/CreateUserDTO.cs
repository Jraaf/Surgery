using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateUserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public int DoctorId { get; set; }
    }
}
