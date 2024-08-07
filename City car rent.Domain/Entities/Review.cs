using City_car_rent.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace City_car_rent.Domain.Entities;
public class Review:Auditable
{
    [ForeignKey("Vehicle")]
    public long VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    [ForeignKey("Customer")]
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
    public int Rating { get; set; } 
    public string Comment { get; set; }
    public DateTime ReviewDate { get; set; }
}
