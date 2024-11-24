using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface ICrud<T> where T : class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<T> UpdateByIdAsync(int id, T model);
        Task<T> AddAsync(T model);
    }
}
