﻿using System;
using System.Collections.Generic;

namespace DataAccess.Entities;

public partial class DoctorsInCaseOperation
{
    public int? CaseOperationId { get; set; }

    public int? DoctorId { get; set; }

    public DateTime StartOfOperating { get; set; }

    public DateTime? EndOfOperating { get; set; }

    public int Id { get; set; }

    public virtual CaseOperation? CaseOperation { get; set; }

    public virtual Doctor? Doctor { get; set; }
}
