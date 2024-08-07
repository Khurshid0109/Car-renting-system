using System.ComponentModel.DataAnnotations;

namespace City_car_rent.Service.DTOs.CustomerDto;
public class CustomerPostModel
{
    [Required]
    [MinLength(3),MaxLength(10)]
    public string FirstName { get; set; }
    [Required]
    [MinLength(3), MaxLength(10)]
    public string LastName { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    [MinLength(5),MaxLength(15)]
    public string Password { get; set; }
    [Required]
    public string DriverLicense { get; set; }
}
