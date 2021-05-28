namespace Snippit.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Models;

    public interface IGenericRepo<T>
            where T : BaseModel
    {
        Task AddEntityAsync(T entity);

        Task UpdateEntityAsync(T entity);

        Task DeleteEntityAsync(T entity);

        Task<IList<T>> GetEntitiesAsync();

        Task<T> GetEntityAsync(int id);

        Task<bool> EntityExistsAsync(int id);
    }
}