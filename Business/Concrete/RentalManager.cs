using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class RentalManager : RentalService
{
    RentalDal rentalDal;
    
    public IDataResult<List<Rental>> GetAll()
    {
        return new SuccessDataResult<List<Rental>>(rentalDal.GetAll(), Messages.RentalListed);
    }

    public IDataResult<List<Rental>> GetById(int id)
    {
        return new SuccessDataResult<List<Rental>>(rentalDal.GetAll(r => r.Id == id));
    }

    public IResult Add(Rental rental)
    {
        if (rental.ReturnDate == null)
        {
            return new ErrorResult(Messages.RentalNotAdded);
        }
        else
        {
            rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalAdded);
        }
    }

    public IResult Update(Rental rental)
    {
        rentalDal.Update(rental);
        return new SuccessResult(Messages.RentalUpdated);
    }

    public IResult Delete(Rental rental)
    {
        rentalDal.Delete(rental);
        return new SuccessResult(Messages.RentalDeleted);
    }
}










