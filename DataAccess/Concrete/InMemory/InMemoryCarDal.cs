using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory;

public class InMemoryCarDal : CarDal
{
    List<Car> cars;

    public InMemoryCarDal()
    {
        cars = new List<Car>
        {
            new Car{Id = 1, BrandId = 1, ColorId = 1,DailyPrice = 180,ModelYear = 2018,Description = "Bmw"},
            new Car{Id = 2, BrandId = 2, ColorId = 34,DailyPrice = 100,ModelYear = 2022,Description = "Audi"},
            new Car{Id = 3, BrandId = 3, ColorId = 54,DailyPrice = 50,ModelYear = 2020,Description = "Ranch Rover"},
            new Car{Id = 4, BrandId = 4, ColorId = 7,DailyPrice = 160,ModelYear = 2012,Description = "Opel"},
            new Car{Id = 1, BrandId = 5, ColorId = 2,DailyPrice = 190,ModelYear = 2015,Description = "Ferrari"},
        };
    }

    public List<Car> GetById(Car car)
    {
        return cars.Where(c => c.Id == car.Id).ToList();
    }

    public List<Car> GetAll()
    {
        return cars;
    }

    public List<Car> Get()
    {
        throw new NotImplementedException();
    }

    public void Add(Car car)
    {
        cars.Add(car);
    }

    public void Delete(Car car)
    {
        Car carToDelete = cars.SingleOrDefault(c => c.Id == car.Id);
        cars.Remove(carToDelete);
    }

    public void Update(Car car)
    {
        Car carToUpdate = cars.SingleOrDefault(c => c.Id == car.Id);
        carToUpdate.BrandId = car.BrandId;
        carToUpdate.ColorId = car.ColorId;
        carToUpdate.DailyPrice = car.DailyPrice;
        carToUpdate.ModelYear = car.ModelYear;
        carToUpdate.Description = car.Description;
    }
}