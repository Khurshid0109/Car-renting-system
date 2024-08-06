using Microsoft.AspNetCore.Http;

namespace City_car_rent.Service.DTOs.CustomerDto;
public class CustomerPutModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public IFormFile DriverLicense { get; set; }

    // Profile image for the user
    public IFormFile ProfileImage { get; set; }
}