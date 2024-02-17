using City_car_rent.Domain.Commons;

namespace City_rent_car.Data.IRepositories;
public interface IRepository<T> where T :Auditable
{
    Task<T> CreateAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(long id);
    Task<T> SelectById(long id);
    IQueryable<T> SelectAll();
    Task SaveAsync();
}
