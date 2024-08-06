using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Review:Auditable
{
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int Rating { get; set; } 
    public string Comment { get; set; }
    public DateTime ReviewDate { get; set; }
}
