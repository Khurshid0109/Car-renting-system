using System.ComponentModel.DataAnnotations;

namespace City_car_rent.Service.DTOs.CategoryDto;
public class CategoryPostModel
{
    [Required]
    [MinLength(2), MaxLength(15)]
    public string Name { get; set; }
    [Required]
    [MinLength(5), MaxLength(150)]
    public string Description { get; set; }
}
