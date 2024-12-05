using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccess.Entities;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string DoctorName { get; set; } = null!;

    public string? DoctorSurname { get; set; }
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual ICollection<DoctorsInCaseOperation> DoctorsInCaseOperations { get; set; } = new List<DoctorsInCaseOperation>();
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public virtual ICollection<DoctorsInChargeOfCase> DoctorsInChargeOfCases { get; set; } = new List<DoctorsInChargeOfCase>();
    [JsonIgnore]
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
