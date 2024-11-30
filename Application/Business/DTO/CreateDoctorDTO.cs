using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateDoctorDTO
    {
        public string DoctorName { get; set; } = null!;

        public string? DoctorSurname { get; set; }
    }
}
