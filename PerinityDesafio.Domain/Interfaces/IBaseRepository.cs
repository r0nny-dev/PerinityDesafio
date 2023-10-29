using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Domain.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity 
{
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
    Task<T> GetByIdAsync(long id);
    Task<List<T>> GetAllAsync();
}
