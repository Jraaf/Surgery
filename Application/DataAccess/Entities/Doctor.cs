using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string DoctorName { get; set; } = null!;

    public string? DoctorSurname { get; set; }
}
