namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Models;

    public interface ISnippitService
    {
        Task<IList<UserSnippit>> GetAll();

        Task<UserSnippit> Get(int? id);

        Task Add(UserSnippit snippit);

        Task Update(UserSnippit snippit);

        Task Delete(UserSnippit snippit);


    }
}