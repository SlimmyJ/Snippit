namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Data.Repositories;
    using Snippit.Models;

    public class SnippitService : ISnippitService
    {
        private IGenericRepo<UserSnippit> _repo;

        public SnippitService(IGenericRepo<UserSnippit> repo)
        {
            _repo = repo;
        }

        public async Task<IList<UserSnippit>> Get(int? id)
        {
            IList<UserSnippit> snippitlist = await _repo.GetEntitiesAsync();
            return snippitlist;
        }

        public async Task<UserSnippit> Get(int id)
        {
            return await _repo.GetEntityAsync(id);
        }

        public async Task Add(UserSnippit snippit)
        {
            await _repo.AddEntityAsync(snippit);
        }

        public async Task Update(UserSnippit snippit)
        {
            await _repo.UpdateEntityAsync(snippit);
        }

        public async Task Delete(UserSnippit snippit)
        {
            await _repo.DeleteEntityAsync(snippit);
        }
    }
}