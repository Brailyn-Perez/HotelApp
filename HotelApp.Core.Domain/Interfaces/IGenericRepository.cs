namespace HotelApp.Core.Domain.Interfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    /// <summary>
    /// Generic repository interface for CRUD operations.
    /// </summary>
    /// <typeparam name="T">The type of the entity.</typeparam>
    /// <remarks>This interface defines the basic CRUD operations for a generic repository.</remarks>
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<T> AddAsync(T entity);
        Task<bool> UpdateAsync(int id, T entity);
        Task<bool> DeleteAsync(int id);
    }
}
