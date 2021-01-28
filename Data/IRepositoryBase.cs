using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ebs.Data
{
    public interface IRepositoryBase<T> where T : class
    {
        Task<T> AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task DeleteRangeAsync(IEnumerable<T> entities);
        Task<T> GetByIdAsync(int id);
        Task<T> GetByIdAsync<TId>(TId id);
        Task<List<T>> ListAsync();
        Task SaveChangesAsync();
        Task UpdateAsync(T entity);
    }
}