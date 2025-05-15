using System.Linq.Expressions;

namespace ProductCRUDApp.Repository.RepositoryInterface
{
    public interface IGenericRepository<T> where T : class
    {
        Task AddAsync(T entity);
        Task Delete(T entity);
        Task<IEnumerable<T>> FindAllAsync();
        Task<T> GetByIdAsync(int id, params Expression<Func<T, object>>[] Includes);
        Task Update(T entity);
    }
}