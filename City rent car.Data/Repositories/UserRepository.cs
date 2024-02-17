using City_rent_car.Data.Data;
using City_car_rent.Domain.Entities;
using City_rent_car.Data.IRepositories;

namespace City_rent_car.Data.Repositories;
public class UserRepository : Repository<User>, IUserRepository
{
    public UserRepository(DataContext context) : base(context)
    {
    }
}
