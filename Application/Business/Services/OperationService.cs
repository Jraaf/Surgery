using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services;

public class OperationService(OperationRepository _repo) : IOperationService
{
    public async Task<Operation> AddAsync(Operation model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Operation>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Operation> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Operation> UpdateByIdAsync(int id, Operation model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.OperationId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}

