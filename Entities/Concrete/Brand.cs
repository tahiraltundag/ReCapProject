using Entities.Abstract;

namespace Entities.Concrete;

public class Brand : Entity
{
    public int Id { get; set; }
    public string Name { get; set; }
}