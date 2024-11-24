using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class MedicalCase
{
    public int CaseId { get; set; }

    public DateTime CaseStartDate { get; set; }

    public DateTime? CaseEndDate { get; set; }

    public int? PatientId { get; set; }

    public int? InsuranceId { get; set; }

    public int? DiagnoseId { get; set; }

    public virtual ICollection<CaseOperation> CaseOperations { get; set; } = new List<CaseOperation>();

    public virtual Diagnosis? Diagnose { get; set; }

    public virtual Insurance? Insurance { get; set; }

    public virtual Patient? Patient { get; set; }

    public virtual ICollection<ResearchesInCase> ResearchesInCases { get; set; } = new List<ResearchesInCase>();
}
