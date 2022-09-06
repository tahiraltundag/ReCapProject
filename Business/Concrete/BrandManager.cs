using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    
    public IDataResult<List<Brand>> GetAll() {
        return new SuccessDataResult<List<Brand>>(brandDal.GetAll(), Messages.BrandListed);
    }

    public IDataResult<List<Brand>> GetById(int id)
    {
        return new SuccessDataResult<List<Brand>>(brandDal.GetAll(b => b.Id == id).ToList());
    }

    public IResult Add(Brand brand)
    {
        brandDal.Add(brand);
        return new SuccessResult(Messages.BrandAdded);
    }

    public IResult Update(Brand brand)
    {
        brandDal.Update(brand);
        return new SuccessResult(Messages.BrandUpdated);
    }

    public IResult Delete(Brand brand)
    {
        brandDal.Delete(brand);
        return new SuccessResult(Messages.BrandDeleted);
    }
}