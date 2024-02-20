using City_car_rent.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City_rent_car.Data.Data;
public class DataContext:DbContext
{
    public DataContext(DbContextOptions<DataContext> options):base(options)
    {
    }
    public DbSet<User> Users { get; set; }
    
}