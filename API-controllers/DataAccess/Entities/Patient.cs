﻿using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class Patient
{
    public int PatientId { get; set; }

    public string PatientName { get; set; } = null!;

    public string? PatientSurname { get; set; }

    public string? PatientPatronymic { get; set; }

    public DateOnly PatientDateOfBirth { get; set; }

    public virtual ICollection<MedicalCase> MedicalCases { get; set; } = new List<MedicalCase>();
}
