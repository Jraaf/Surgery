using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string DoctorName { get; set; } = null!;

    public string? DoctorSurname { get; set; }

    public virtual ICollection<DoctorsInCaseOperation> DoctorsInCaseOperations { get; set; } = new List<DoctorsInCaseOperation>();

    public virtual ICollection<DoctorsInChargeOfCase> DoctorsInChargeOfCases { get; set; } = new List<DoctorsInChargeOfCase>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
