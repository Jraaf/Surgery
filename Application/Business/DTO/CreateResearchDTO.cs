using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DTO
{
    public class CreateResearchDTO
    {
        public string ResearchName { get; set; } = null!;

        public string ResearchNormalValues { get; set; } = null!;

        public decimal ResearchCost { get; set; }
    }
}
