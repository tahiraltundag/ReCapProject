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
        foreach (var brand in brandManager.GetAll())
        {
            Console.WriteLine(brand.Name);
        }
    }

    private static void ColorTest()
    {
        ColorManager colorManager = new ColorManager(new EfColorDal());
        foreach (var color in colorManager.GetAll())
        {
            Console.WriteLine(color.Name);
        }
    }

    private static void CarTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());

        foreach (Car car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}