using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateInsuranceDTO
    {
        public string InsuranceName { get; set; } = null!;

        public decimal InsuranceCoverageAmount { get; set; }
    }
}
