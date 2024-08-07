using City_car_rent.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace City_car_rent.Domain.Entities;
public class Vehicle:Auditable
{
    public string Maker { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string LicensePlate { get; set; }
    public decimal RentalPricePerDay { get; set; }
    public bool IsAvailable { get; set; }

    [ForeignKey("Category")]
    public long CategoryId { get; set; }
    public Category Category { get; set; }

    // List of images for the vehicle
    public List<string> Images { get; set; } = new List<string>();

    // Reviews for the vehicle
    public ICollection<Review>? Reviews { get; set; } 
}
