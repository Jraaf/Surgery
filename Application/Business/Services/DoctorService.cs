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
public class DoctorService(IDoctorRepository _repo) : IDoctorService
{
    public async Task<Doctor> AddAsync(Doctor model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Doctor>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Doctor> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Doctor> UpdateByIdAsync(int id, Doctor model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.DoctorId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}