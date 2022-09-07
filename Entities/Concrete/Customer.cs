using Core.Entities;

namespace Entities.Concrete;

public class Customer : User, Entity
{
    public int UserId { get; set; }
    public string CompanyName { get; set; }
}