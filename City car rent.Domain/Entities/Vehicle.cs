using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Vehicle:Auditable
{
    public string Maker { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string LicensePlate { get; set; }
    public decimal RentalPricePerDay { get; set; }
    public bool IsAvailable { get; set; }

    // Reference to the category
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    // List of images for the vehicle
    public ICollection<string> Images { get; set; }

    // Reviews for the vehicle
    public ICollection<Review>? Reviews { get; set; } 
}
