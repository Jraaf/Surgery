using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class ResearchesInCase
{
    public int LaboratoryResearchInCaseId { get; set; }

    public int? CaseId { get; set; }

    public int? ResearchId { get; set; }

    public DateTime ResearchDatetime { get; set; }
    [JsonIgnore]
    public string ResearchResult { get; set; } = null!;

    public virtual MedicalCase? Case { get; set; }

    public virtual Research? Research { get; set; }
}
