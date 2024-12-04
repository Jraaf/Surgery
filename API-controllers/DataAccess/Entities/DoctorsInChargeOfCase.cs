using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class DoctorsInChargeOfCase
{
    public int? CaseId { get; set; }

    public int? DoctorId { get; set; }

    public int Id { get; set; }
    [JsonIgnore]
    public virtual MedicalCase? Case { get; set; }
    [JsonIgnore]
    public virtual Doctor? Doctor { get; set; }
}
