using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using TouristAgency.Domain;

namespace TouristAgency.Repositories.Generic
{
    public class DbRepository<T> : IDbRepository<T> where T : class, IDbEntity
    {
        DbContext _context;
        public DbRepository(DbContext context)
        {
            _context = context;
        }

        public DbContext DbContext => _context;
        public IQueryable<T> AllItems => _context.Set<T>();

        public async Task<bool> AddItemAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> AddItemsAsync(IEnumerable<T> items)
        {
            await _context.Set<T>().AddRangeAsync(items);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteItemAsync(Guid id)
        {
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            T item = _context.Set<T>().FirstOrDefault(i => i.Id == id);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            if (item == null) { return false; }
            _context.Set<T>().Remove(item);
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<T> GetItemAsync(Guid id)
        {
#pragma warning disable CS8603 // Possible null reference return.
            return await _context.Set<T>().FirstOrDefaultAsync(i => i.Id == id);
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<List<T>> ToListAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<bool> UpdateItemAsync(T item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;
        }

        public async Task<int> SaveChangesAsync()
        {
            try
            {
                return await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return -1;
            }
        }
    }
}
