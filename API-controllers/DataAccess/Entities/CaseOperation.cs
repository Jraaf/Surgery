using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class CaseOperation
{
    public int CaseOperationId { get; set; }

    public int? CaseId { get; set; }

    public int? OperationId { get; set; }

    public DateTime StartOfOperation { get; set; }

    public DateTime? EndOfOperation { get; set; }

    public virtual MedicalCase? Case { get; set; }

    public virtual ICollection<DoctorsInCaseOperation> DoctorsInCaseOperations { get; set; } = new List<DoctorsInCaseOperation>();

    public virtual Operation? Operation { get; set; }
}
