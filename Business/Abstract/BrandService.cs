using Entities.Concrete;

namespace Business.Abstract;

public interface BrandService
{
    List<Brand> GetAll();
    List<Brand> GetById(int id);
    void Add(Brand brand);
    void Update(Brand brand);
    void Delete(Brand brand);
}