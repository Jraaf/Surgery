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

public class DiagnosisService(IDiagnosisRepository _repo) : IDiagnosisService
{
    public async Task<Diagnosis> AddAsync(Diagnosis model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Diagnosis>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Diagnosis> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Diagnosis> UpdateByIdAsync(int id, Diagnosis model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.DiagnoseId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}
