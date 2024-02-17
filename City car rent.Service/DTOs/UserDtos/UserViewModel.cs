using City_car_rent.Domain.Enums;

namespace City_car_rent.Service.DTOs.UserDtos;
public class UserViewModel
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Username { get; set; }
    public Role Role { get; set; }
    public string Password { get; set; }
}
