using City_car_rent.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace City_rent_car.Data.Data;
public class DataContext:DbContext
{
    public DbSet<User> Users { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("server=localhost; Port=5432; Database=CarRent; User Id=postgres; Password=Xy010903");
    }
}