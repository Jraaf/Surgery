using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class DoctorsInChargeOfCase
{
    public int? CaseId { get; set; }

    public int? DoctorId { get; set; }
    
    public virtual MedicalCase? Case { get; set; }
    public virtual Doctor? Doctor { get; set; }
}
