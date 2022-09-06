using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CarManager : CarService
{
    CarDal carDal;

    public CarManager(CarDal carDal)
    {
        this.carDal = carDal;
    }
    
    public IDataResult<List<Car>> GetAll()
    {
        return new SuccessDataResult<List<Car>>(carDal.GetAll(), Messages.CarListed);
    }

    public IDataResult<List<Car>> GetById(int id)
    {
        return new SuccessDataResult<List<Car>>(carDal.GetAll(c=>c.Id == id).ToList(), Messages.GetCarById);
    }

    public IDataResult<List<Car>> GetCarsByBrandId(int id)
    {
        return new SuccessDataResult<List<Car>>(carDal.GetAll(c=>c.BrandId == id),Messages.GetCarByBrandId);
    }

    public IDataResult<List<Car>> GetCarsByColorId(int id)
    {
        return new SuccessDataResult<List<Car>>(carDal.GetAll(c => c.ColorId == id), Messages.GetCarByColorId);
    }

    public IResult Add(Car car)
    {
        if (car.Description.Length >= 2 && car.DailyPrice > 0)
        {
            carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }
        else
        {
            Console.WriteLine("Girilen değerler kriterlere uygun değil");
            return new ErrorResult(Messages.CarNotAdded);
        }
    }

    public IResult Update(Car car)
    {
        carDal.Update(car); 
        return new SuccessResult(Messages.CarUpdated);
    }

    public IResult Delete(Car car)
    {
        carDal.Delete(car);
        return new SuccessResult(Messages.CarDeleted);
    }
}
