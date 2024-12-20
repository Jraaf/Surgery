﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class ResearchesInCase
{
    public int LaboratoryResearchInCaseId { get; set; }

    public int? CaseId { get; set; }

    public int? ResearchId { get; set; }

    public DateTime ResearchDatetime { get; set; }

    public string ResearchResult { get; set; } = null!;
    [JsonIgnore]
    public virtual MedicalCase? Case { get; set; }
    [JsonIgnore]
    public virtual Research? Research { get; set; }
}
