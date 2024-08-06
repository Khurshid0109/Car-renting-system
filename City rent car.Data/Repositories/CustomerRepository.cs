using City_rent_car.Data.Data;
using City_car_rent.Domain.Entities;
using City_rent_car.Data.IRepositories;

namespace City_rent_car.Data.Repositories;
public class CustomerRepository : Repository<Customer>, ICustomerRepository
{
    public CustomerRepository(DataContext context) : base(context)
    {
    }
}
