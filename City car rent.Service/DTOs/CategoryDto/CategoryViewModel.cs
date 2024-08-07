using System.ComponentModel.DataAnnotations;

namespace City_car_rent.Service.DTOs.CategoryDto;
public class CategoryViewModel
{
    [Key]
    public long Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
}
