using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PadawanInfra.Context;
using PadawanInfra.Interfaces;
using ProjetoModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawanInfra.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AlunoContext _dbContext;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(AlunoContext dbContext, DbSet<TEntity> dbSet)
        {
            _dbContext = dbContext;
            _dbSet = dbSet;
        }

        public async Task CreateAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            _dbContext.SaveChanges();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            EntityEntry<TEntity> entry;
            var objToUpdate = await _dbSet.FindAsync(entity.Id);
            entry = _dbContext.Entry(objToUpdate);
            entry.CurrentValues.SetValues(entity);
            entry.State = EntityState.Modified;
            _dbContext.SaveChanges();
        }
        public async Task DeleteAsync(Guid id)
        {
            var entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        protected IQueryable Query() => _dbSet.AsNoTracking();

        public async Task<TEntity> GetByIdAsync(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}
