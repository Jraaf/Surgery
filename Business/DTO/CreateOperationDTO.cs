using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateOperationDTO
    {
        public string OperationName { get; set; } = null!;

        public decimal OperationCost { get; set; }
    }
}
