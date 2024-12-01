using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Insurance
{
    public int InsuranceId { get; set; }

    public string InsuranceName { get; set; } = null!;

    public decimal InsuranceCoverageAmount { get; set; }

    public virtual ICollection<MedicalCase> MedicalCases { get; set; } = new List<MedicalCase>();
}
