namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Data.Repositories;
    using Snippit.Models;

    public class SnippitService : ISnippitService
    {
        private IGenericRepo<Snippit> _repo;

        public SnippitService(IGenericRepo<Snippit> repo)
        {
            _repo = repo;
        }

        public async Task<IList<Snippit>> Get()
        {
            IList<Snippit> snippitlist = await _repo.GetEntitiesAsync();
            return snippitlist;
        }

        public async Task<Snippit> Get(int id)
        {
            return await _repo.GetEntityAsync(id);
        }

        public async Task Add(Snippit snippit)
        {
            await _repo.AddEntityAsync(snippit);
        }

        public async Task Update(Snippit snippit)
        {
            await _repo.UpdateEntityAsync(snippit);
        }

        public async Task Delete(Snippit snippit)
        {
            await _repo.DeleteEntityAsync(snippit);
        }
    }
}

