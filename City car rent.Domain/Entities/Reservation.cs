using City_car_rent.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace City_car_rent.Domain.Entities;
public class Reservation:Auditable
{
    [ForeignKey("Vehicle")]
    public long VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    [ForeignKey("Customer")]
    public long CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime ReservationDate { get; set; }  
    public DateTime StartDate { get; set; }      
    public DateTime EndDate { get; set; }         
    public bool IsConfirmed { get; set; }
}
