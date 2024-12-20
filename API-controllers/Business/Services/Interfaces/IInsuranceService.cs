﻿using Business.DTO;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces;

public interface IInsuranceService : ICrud<Insurance, CreateInsuranceDTO>
{
}
