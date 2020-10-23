using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PadawanInfra.Interfaces
{
    public interface IGenericRepository<TEntity>
    {
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task CreateAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
        Task DeleteAsync(Guid id);
    }
}
