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

public class MedicalCaseService :Service<MedicalCase,CreateMedicalCaseDTO>, IMedicalCaseService
{
    private readonly IMedicalCaseRepository repo;
    private readonly IMapper mapper;

    public MedicalCaseService(IMedicalCaseRepository _repo, IMapper _mapper)
        :base(_mapper, _repo)
    {
        repo = _repo;
        mapper = _mapper;
    }

    public async Task<List<MedicalCase>> GetMyMedicalCases(int doctorId)
    {
        var data = await repo.GetMyMedicalCases(doctorId);
        return mapper.Map<List<MedicalCase>>(data);
    }
}
