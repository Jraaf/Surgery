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

public class PatientService(IPatientRepository _repo) : IPatientService
{
    public async Task<Patient> AddAsync(Patient model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Patient>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Patient> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Patient> UpdateByIdAsync(int id, Patient model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.PatientId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}

