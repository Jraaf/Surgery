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

public class MedicalCaseService(IMedicalCaseRepository _repo) : IMedicalCaseService
{
    public async Task<MedicalCase> AddAsync(MedicalCase model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<MedicalCase>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<MedicalCase> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<MedicalCase> UpdateByIdAsync(int id, MedicalCase model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.CaseId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}
