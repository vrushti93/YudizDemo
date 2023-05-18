using YudizPractical.Domain;

namespace YudizPractical.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<int> CreateAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task DeleteAsync(int id);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
    }
}
