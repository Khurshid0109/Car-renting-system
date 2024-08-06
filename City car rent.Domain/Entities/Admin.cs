using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Admin:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string UserName { get; set; }
    public string Email { get; set; }
}
