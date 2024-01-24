using DeliveryTrackerAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace DeliveryTrackerAPI.Repositories
{
    public class DriverRepository<T> : IDriverRepository<T>
        where T : BaseEntity
    {
        private AppDbContext _context;

        public DriverRepository(AppDbContext context)
        {
            _context = context;
        }
        public Task AddAsync(T entity)
        {
            _context.Set<T>().Add(entity);
            return _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _context.Set<T>().FindAsync(id);
            if (item != null)
            {
                _context.Set<T>().Remove(item);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context
                .Set<T>()
                .ToListAsync();
        }

        public Task<T> GetByIdAsync(int id)
        {
             return _context.Set<T>()
                .FirstOrDefaultAsync(
                    item => item.Id == id
                );
        }

        public async Task UpdateAsync(T entity)
        {
            var item = await _context.Set<T>()
                .FirstOrDefaultAsync(item => item.Id == entity.Id);
            if (item != null)
            {
                _context.Set<T>().Update(item);
                await _context.SaveChangesAsync();
            }
        }
    }
}
