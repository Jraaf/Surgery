﻿using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces;

public interface IMedicalCaseService : ICrud<MedicalCase>
{
    Task<List<MedicalCase>> GetMyMedicalCases(int doctorId);
}
