using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Operation
{
    public int OperationId { get; set; }

    public string OperationName { get; set; } = null!;

    public decimal OperationCost { get; set; }

    public virtual ICollection<CaseOperation> CaseOperations { get; set; } = new List<CaseOperation>();
}
