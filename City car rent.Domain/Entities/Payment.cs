using City_car_rent.Domain.Commons;

namespace City_car_rent.Domain.Entities;
public class Payment:Auditable
{
    public int RentalId { get; set; }
    public Rental Rental { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } 
}
