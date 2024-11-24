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

public class InsuranceService(IInsuranceRepository _repo) : IInsuranceService
{
    public async Task<Insurance> AddAsync(Insurance model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Insurance>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Insurance> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Insurance> UpdateByIdAsync(int id, Insurance model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.InsuranceId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}
