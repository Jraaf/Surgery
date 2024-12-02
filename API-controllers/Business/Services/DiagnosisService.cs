using AutoMapper;
using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services;

public class DiagnosisService : Service<Diagnosis, CreateDiagnosisDTO>, IDiagnosisService
{
    private readonly IDiagnosisRepository repo;
    private readonly IMapper mapper;

    public DiagnosisService(IDiagnosisRepository _repo, IMapper _mapper)
        : base(_mapper, _repo)
    {
        repo = _repo;
        mapper = _mapper;
    }
    public async new Task<List<Diagnosis>> GetAllAsync()
    {
        return await repo.GetAllWithDetails();
    }
}