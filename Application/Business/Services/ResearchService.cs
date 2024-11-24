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

public class ResearchService(IResearchRepository _repo) : IResearchService
{
    public async Task<Research> AddAsync(Research model)
    {
        return await _repo.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        await _repo.DeleteAsync(data);
    }

    public async Task<List<Research>> GetAllAsync()
    {
        return await _repo.GetAllAsync();
    }

    public async Task<Research> GetAsync(int id)
    {
        return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
    }

    public async Task<Research> UpdateByIdAsync(int id, Research model)
    {
        var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        model.ResearchId = id;
        data = model;
        return await _repo.UpdateAsync(data);
    }
}
