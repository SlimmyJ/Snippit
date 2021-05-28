namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Models;

    public interface ISnippitService
    {
        Task<IList<Snippit>> Get();

        Task<Snippit> Get(int id);

        Task Add(Snippit snippit);

        Task Update(Snippit snippit);

        Task Delete(Snippit snippit);
    }
}