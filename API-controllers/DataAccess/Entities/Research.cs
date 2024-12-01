using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Research
{
    public int ResearchId { get; set; }

    public string ResearchName { get; set; } = null!;

    public string ResearchNormalValues { get; set; } = null!;

    public decimal ResearchCost { get; set; }

    public virtual ICollection<ResearchesInCase> ResearchesInCases { get; set; } = new List<ResearchesInCase>();
}
