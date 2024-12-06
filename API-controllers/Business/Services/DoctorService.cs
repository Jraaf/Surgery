using API_controllers.Business.DTO;
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
public class DoctorService : Service<Doctor, CreateDoctorDTO>, IDoctorService
{
    private readonly IDoctorRepository repo;
    private readonly IMapper mapper;

    public DoctorService(IDoctorRepository _repo, IMapper _mapper)
        : base(_mapper, _repo)
    {
        repo = _repo;
        mapper = _mapper;
    }

    public async Task<bool> AssignMedicalCase(CreateDoctorsInChargeOfCaseDTO dto)
    {
        var entity = mapper.Map<DoctorsInChargeOfCase>(dto);
        return await repo.AssignMedicalCase(entity);
    }

    public async Task<bool> AssignOperation(CreateDoctorsInCaseOperationsDTO dto)
    {
        var entity = mapper.Map<DoctorsInCaseOperation>(dto);
        return await repo.AssignOperation(entity);
    }

    public async Task<List<Doctor?>> GetBusyDostors()
    {
        return await repo.GetBusyDoctors() ?? throw new NotFoundException();
    }
    public async Task<List<Doctor?>> GetBestDoctors()
    {
        return await repo.GetBestDoctors();
    }
}