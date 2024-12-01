using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreatePatientDTO
    {
        public string PatientName { get; set; } = null!;

        public string? PatientSurname { get; set; }

        public string? PatientPatronymic { get; set; }

        public DateOnly PatientDateOfBirth { get; set; }
    }
}
