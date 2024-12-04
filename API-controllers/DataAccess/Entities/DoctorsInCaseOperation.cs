using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class DoctorsInCaseOperation
{
    public int? CaseOperationId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime StartOfOperating { get; set; }

    public DateTime? EndOfOperating { get; set; }

    public int Id { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual CaseOperation? CaseOperation { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual Doctor? Doctor { get; set; }
}
