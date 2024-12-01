using AutoMapper;
using Business.DTO;
using Business.Exceptions;
using Business.Services.Interfaces;
using DataAccess.Entities;
using DataAccess.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class Service<T, CreateTDTO> : ICrud<T, CreateTDTO>
        where T : class
        where CreateTDTO : class
    {
        private readonly IMapper _mapper;
        private readonly IRepo<T, int> _repo;

        public Service(IMapper mapper,IRepo<T,int> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }
        public async Task<T> AddAsync(CreateTDTO model)
        {
            var data = _mapper.Map<T>(model);
            return await _repo.AddAsync(data);
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
            await _repo.DeleteAsync(data);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _repo.GetAllAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _repo.GetAsync(id) ?? throw new NotFoundException(id);
        }

        public async Task<T> UpdateByIdAsync(int id, CreateTDTO model)
        {
            var data = await _repo.GetAsync(id) ?? throw new NotFoundException(id);
            return await _repo.UpdateAsync(_mapper.Map(model, data));
        }
    }
}
