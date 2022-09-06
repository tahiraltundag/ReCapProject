using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface CarService
{ 
    IDataResult<List<Car>> GetAll();
    IDataResult<List<Car>> GetById(int id);
    IDataResult<List<Car>> GetCarsByBrandId(int id);
    IDataResult<List<Car>> GetCarsByColorId(int id);
    IResult Add(Car car);
    IResult Update(Car car);
    IResult Delete(Car car);
}