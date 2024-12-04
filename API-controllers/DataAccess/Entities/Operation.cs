using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class Operation
{
    public int OperationId { get; set; }

    public string OperationName { get; set; } = null!;

    public decimal OperationCost { get; set; }
    [JsonIgnore]
    public virtual ICollection<CaseOperation> CaseOperations { get; set; } = new List<CaseOperation>();
}
