using Core.Utilities.Results; 
using Entities.Concrete;

namespace Business.Abstract; public interface BrandService
{
    IDataResult<List<Brand>> GetAll();
    IDataResult<List<Brand>> GetById(int id);
    IResult Add(Brand brand);
    IResult Update(Brand brand);
    IResult Delete(Brand brand);
}