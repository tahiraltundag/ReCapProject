using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract;

public interface CarDal : EntityRepository<Car>
{
    List<CarDetailDto> GetCarDetails();
}