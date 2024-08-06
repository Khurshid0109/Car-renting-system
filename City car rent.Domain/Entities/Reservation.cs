using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Reservation:Auditable
{
    public int VehicleId { get; set; }
    public Vehicle Vehicle { get; set; }
    public int CustomerId { get; set; }
    public Customer Customer { get; set; }
    public DateTime ReservationDate { get; set; }  
    public DateTime StartDate { get; set; }      
    public DateTime EndDate { get; set; }         
    public bool IsConfirmed { get; set; }
}
