using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Interfaces
{
    public interface ICrud<T,TDTO> 
        where T : class
        where TDTO : class
    {
        Task<T> GetAsync(int id);
        Task<List<T>> GetAllAsync();
        Task DeleteAsync(int id);
        Task<T> UpdateByIdAsync(int id, TDTO model);
        Task<T> AddAsync(TDTO model);
    }
}
