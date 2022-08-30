using Entities.Concrete;

namespace Business.Abstract;

public interface CarService
{
    List<Car> GetAll();
    List<Car> GetCarsByBrandId(int id);
    List<Car> GetCarsByColorId(int id);
    void Add(Car car);

}