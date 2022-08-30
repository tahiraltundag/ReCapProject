using Business.Abstract;
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
    
    public List<Car> GetAll()
    {
        return carDal.GetAll();
    }

    public List<Car> GetCarsByBrandId(int id)
    {
        return carDal.GetAll(c=>c.BrandId == id);
    }

    public List<Car> GetCarsByColorId(int id)
    {
        return carDal.GetAll(c => c.ColorId == id);
    }

    public void Add(Car car)
    {
        if (car.Description.Length >= 2 && car.DailyPrice > 0)
        {
            carDal.Add(car);
        }
        else
        {
            Console.WriteLine("Girilen değerler kriterlere uygun değil");
        }
    }
}
