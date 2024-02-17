using City_car_rent.Domain.Enums;
using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class User: Auditable
{
    public string Name { get; set; }
    public string Username { get; set; }
    public Role Role { get; set; }
    public string Password { get; set; }
}
