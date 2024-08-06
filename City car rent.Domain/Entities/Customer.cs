using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Customer:Auditable
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string DriverLicense { get; set; }

    // Profile image for the user
    public string ProfileImage { get; set; }
}
