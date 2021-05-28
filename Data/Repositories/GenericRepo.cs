namespace Snippit.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore;

    using Snippit.Models;

    public class GenericRepo<T> : IGenericRepo<T>
            where T : BaseModel

    {
        private SnippitContext _context;

        public GenericRepo(SnippitContext context)
        {
            _context = context;
        }

        public async Task AddEntityAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEntityAsync(T entity)
        {
            _context.Attach(entity);
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEntityAsync(T entity)
        {
            _context.Attach(entity);
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IList<T>> GetEntitiesAsync()
        {
            var dbset = _context.Set<T>();
            return await dbset.ToListAsync();
        }

        public async Task<T> GetEntityAsync(int id)
        {
            var dbset = _context.Set<T>();
            return await dbset.FindAsync(id);
        }

        public async Task<bool> EntityExistsAsync(int id)
        {
            var dbset = _context.Set<T>();
            return await dbset.AnyAsync(x => x.Id == id);
        }
    }
}
