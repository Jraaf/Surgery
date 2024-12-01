using AutoMapper;
using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services;

public class PatientService : Service<Patient, CreatePatientDTO>, IPatientService
{
    public PatientService(IMapper _mapper, IPatientRepository _repo)
        : base(_mapper, _repo)
    {

    }
}

