namespace City_car_rent.Service.DTOs.CustomerDto;
public class CustomerViewModel
{
    public  long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string DriverLicense { get; set; }

    // Profile image for the user
    public string ProfileImage { get; set; }
}
