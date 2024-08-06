using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Category:Auditable
{
    public string Name { get; set; } 
    public string Description { get; set; }

    // List of vehicles in this category
    public ICollection<Vehicle> Vehicles { get; set; }
}
