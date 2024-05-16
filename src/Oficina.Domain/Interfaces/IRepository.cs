using Oficina.Domain.Models;

namespace Oficina.Domain.Interfaces;

public  interface IRepository<T> where T : Entity
{
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task DeleteAsync(T entity);
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetById(int id);

}
