using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface RentalService
{
    IDataResult<List<Rental>> GetAll();
    IDataResult<List<Rental>> GetById(int id);
    IResult Add(Rental rental);
    IResult Update(Rental rental);
    IResult Delete(Rental rental);
}