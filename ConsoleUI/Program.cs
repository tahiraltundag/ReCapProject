using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;

class Program
{
    public static void Main(string[] args)
    {
        CarTest();
        ColorTest();
        BrandTest();
    }

    private static void BrandTest()
    {
        BrandManager brandManager = new BrandManager(new EfBrandDal());

        var result = brandManager.GetAll();
        if (result.Success==true)
        {
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Name);
            }
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());

        var result = colorManager.GetAll();
        if (result.Success == true)
        {
            foreach (var color in result.Data)
            {
                Console.WriteLine(color.Name);
            }
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        var result = carManager.GetAll();
        if (result.Success == true)
        {
            foreach (Car car in result.Data)
            { 
                Console.WriteLine(car.Description);
            }
        }
    }
}