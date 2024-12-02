using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateMedicalCaseDTO
    {
        public DateTime CaseStartDate { get; set; } = DateTime.Now;

        public DateTime? CaseEndDate { get; set; } = DateTime.Now.AddMonths(1);

        public int? PatientId { get; set; }

        public int? InsuranceId { get; set; }

        public int? DiagnoseId { get; set; }
    }
}
