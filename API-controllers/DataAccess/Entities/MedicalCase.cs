using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class MedicalCase
{
    public int CaseId { get; set; }

    public DateTime CaseStartDate { get; set; }

    public DateTime? CaseEndDate { get; set; }

    public int? PatientId { get; set; }

    public int? InsuranceId { get; set; }

    public int? DiagnoseId { get; set; }
    [JsonIgnore]
    public virtual ICollection<CaseOperation> CaseOperations { get; set; } = new List<CaseOperation>();
    [JsonIgnore]
    public virtual Diagnosis? Diagnose { get; set; }
    [JsonIgnore]
    public virtual ICollection<DoctorsInChargeOfCase> DoctorsInChargeOfCases { get; set; } = new List<DoctorsInChargeOfCase>();
    [JsonIgnore]
    public virtual Insurance? Insurance { get; set; }
    [JsonIgnore]
    public virtual Patient? Patient { get; set; }
    [JsonIgnore]
    public virtual ICollection<ResearchesInCase> ResearchesInCases { get; set; } = new List<ResearchesInCase>();
}
