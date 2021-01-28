using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace Ebs.Data
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        #region Constructor
        private readonly DbContext dbContext;
        public RepositoryBase(DbContext dbContext) => this.dbContext = dbContext;
        #endregion

        public async Task<T> AddAsync(T entity)
        {
            dbContext.Set<T>().Add(entity);

            await SaveChangesAsync();

            return entity;
        }
        public async Task UpdateAsync(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;

            await SaveChangesAsync();
        }
        public async Task DeleteAsync(T entity)
        {
            dbContext.Set<T>().Remove(entity);

            await SaveChangesAsync();
        }
        public async Task DeleteRangeAsync(IEnumerable<T> entities)
        {
            dbContext.Set<T>().RemoveRange(entities);

            await SaveChangesAsync();
        }
        public async Task SaveChangesAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
        public async Task<T> GetByIdAsync<TId>(TId id)
        {
            return await dbContext.Set<T>().FindAsync(id);
        }
        public async Task<List<T>> ListAsync()
        {
            return await dbContext.Set<T>().ToListAsync();
        }

    }
}