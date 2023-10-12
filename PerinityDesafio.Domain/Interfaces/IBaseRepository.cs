using PerinityDesafio.Domain.Entities;

namespace PerinityDesafio.Domain.Interfaces;

public interface IBaseRepository<T> where T : BaseEntity 
{
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<T> DeleteAsync(T entity);
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
}
