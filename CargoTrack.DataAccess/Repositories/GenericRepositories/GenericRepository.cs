

using CargoTrack.DataAccess.Context;
using CargoTrack.Entity.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace CargoTrack.DataAccess.Repositories.GenericRepositories
{
    public class GenericRepository<TEntitiy> : IRepository<TEntitiy> where TEntitiy : BaseEntity
    {
        private readonly AppDbContext _context;
        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(TEntitiy entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(TEntitiy entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
          
        }

        public async Task<List<TEntitiy>> GetAllAsync()
        {
            return await _context.Set<TEntitiy>().ToListAsync();
        }

        public async Task<TEntitiy> GetByIdAsync(Guid id)
        {
            return await _context.Set<TEntitiy>().FindAsync(id);
        }

        public async Task UpdateAsync(TEntitiy entity)
        {
           _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}
