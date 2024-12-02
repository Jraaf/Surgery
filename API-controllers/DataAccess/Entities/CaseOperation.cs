using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class CaseOperation
{
    public int CaseOperationId { get; set; }

    public int? CaseId { get; set; }

    public int? OperationId { get; set; }

    public DateTime StartOfOperation { get; set; }

    public DateTime? EndOfOperation { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public virtual MedicalCase? Case { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
    public virtual Operation? Operation { get; set; }
}
