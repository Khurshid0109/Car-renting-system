using City_rent_car.Data.Data;
using City_car_rent.Domain.Commons;
using Microsoft.EntityFrameworkCore;
using City_rent_car.Data.IRepositories;

namespace City_rent_car.Data.Repositories;
public class Repository<T> : IRepository<T> where T : Auditable
{
    private readonly DataContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(DataContext context)
    {
        _context = context;
        _dbSet = context.Set<T>();
    }

    public async Task<T> CreateAsync(T entity)
    {
        var entry = await _dbSet.AddAsync(entity);

        return entry.Entity;
    }

    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));
        _dbSet.Remove(entity);

        return true;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        var entry = _context.Update(entity);
        return entry.Entity;
    }

    public async Task SaveAsync()
    => await _context.SaveChangesAsync();

    public async Task<T> SelectById(long id)
    {
       var entry = await _dbSet.FirstOrDefaultAsync(e => e.Id.Equals(id));
       return entry;
    }

    public IQueryable<T> SelectAll()
   => _dbSet;
}
