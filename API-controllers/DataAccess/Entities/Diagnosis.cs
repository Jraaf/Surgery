using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class Diagnosis
{
    public int DiagnoseId { get; set; }

    public string DiagnoseDescription { get; set; } = null!;
    [JsonIgnore]
    public virtual ICollection<MedicalCase> MedicalCases { get; set; } = new List<MedicalCase>();
}
