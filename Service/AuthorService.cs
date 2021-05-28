namespace Snippit.Service
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Snippit.Data.Repositories;
    using Snippit.Models;

    public class AuthorService : IAuthorService
    {
        private IGenericRepo<Author> _repo;

        public AuthorService(IGenericRepo<Author> repo)
        {
            _repo = repo;
        }

        public async Task<IList<Author>> Get()
        {
            IList<Author> snippitlist = await _repo.GetEntitiesAsync();
            return snippitlist;
        }

        public async Task<Author> Get(int id)
        {
            return await _repo.GetEntityAsync(id);
        }

        public async Task Add(Author snippit)
        {
            await _repo.AddEntityAsync(snippit);
        }

        public async Task Update(Author snippit)
        {
            await _repo.UpdateEntityAsync(snippit);
        }

        public async Task Delete(Author author)
        {
            await _repo.DeleteEntityAsync(author);
        }
    }
}