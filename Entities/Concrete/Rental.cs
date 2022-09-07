using Core.Entities;

namespace Entities.Concrete;

public class Rental : Entity
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public int CustomerId { get; set; }
    public DateTime RentDate { get; set; }
    public DateTime ReturnDate { get; set; }
    
}