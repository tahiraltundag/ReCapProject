using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class BrandManager : BrandService
{
    BrandDal brandDal;

    public BrandManager(BrandDal brandDal)
    {
        this.brandDal = brandDal;
    }
    
    public List<Brand> GetAll()
    {
        return brandDal.GetAll();
    }

    public List<Brand> GetById(int id)
    {
        return brandDal.GetAll(b => b.Id == id).ToList();
    }

    public void Add(Brand brand)
    {
        brandDal.Add(brand);
    }

    public void Update(Brand brand)
    {
        brandDal.Update(brand);
    }

    public void Delete(Brand brand)
    {
        brandDal.Delete(brand);
    }
}