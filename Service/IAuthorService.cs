namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Models;

    public interface IAuthorService
    {
        Task<IList<Author>> Get();

        Task<Author> Get(int id);

        Task Add(Author snippit);

        Task Update(Author snippit);

        Task Delete(Author author);
    }
}