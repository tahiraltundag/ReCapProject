using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Concrete.EntityFramework;

public class EfCarDal : EfEntityRepositoryBase<Car, NorthwindContext>, CarDal
{
    public List<CarDetailDto> GetCarDetails()
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var result = from c in context.Cars
                         join b in context.Brands on c.BrandId equals b.Id
                         join cl in context.Colors on c.ColorId equals cl.Id
                         select new CarDetailDto()
                         {
                             CarName = c.Description, 
                             BrandName = b.Name,
                             ColorName = cl.Name, 
                             DailyPrice = c.DailyPrice
                         };
            return result.ToList();
        }
    }
}

