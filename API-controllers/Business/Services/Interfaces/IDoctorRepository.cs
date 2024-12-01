﻿using Business.DTO;
using DataAccess.Entities;

namespace Business.Services.Interfaces;

public interface IDoctorService: ICrud<Doctor,CreateDoctorDTO>
{
}
