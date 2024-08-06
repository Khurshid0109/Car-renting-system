using Microsoft.AspNetCore.Http;

namespace City_car_rent.Service.DTOs.CustomerDto;
public class CustomerPostModel
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }
    public string DriverLicense { get; set; }
}
