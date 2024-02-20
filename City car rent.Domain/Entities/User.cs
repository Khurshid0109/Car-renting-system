using City_car_rent.Domain.Enums;
using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class User: Auditable
{
    public string Name { get; set; }
    public string Username { get; set; }
    public string PhoneNumber { get; set; }
    public string PassportImg { get; set; }
    public bool IsVerified { get; set; } = false;
    public string Password { get; set; }
    public Role Role { get; set; }
}
