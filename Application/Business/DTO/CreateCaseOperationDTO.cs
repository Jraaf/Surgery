using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateCaseOperationDTO
    {
        public int? CaseId { get; set; }

        public int? OperationId { get; set; }

        public DateTime StartOfOperation { get; set; }

        public DateTime? EndOfOperation { get; set; }
    }
}
