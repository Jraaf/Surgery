using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Diagnosis
{
    public int DiagnoseId { get; set; }

    public string DiagnoseDescription { get; set; } = null!;

    public virtual ICollection<MedicalCase> MedicalCases { get; set; } = new List<MedicalCase>();
}
