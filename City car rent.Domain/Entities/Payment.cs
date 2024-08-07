using City_car_rent.Domain.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace City_car_rent.Domain.Entities;
public class Payment:Auditable
{
    [ForeignKey("Rental")]
    public long RentalId { get; set; }
    public Rental Rental { get; set; }
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; }
    public string PaymentMethod { get; set; } 
}
