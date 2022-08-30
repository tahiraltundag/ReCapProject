using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

class Program
{
    public static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());

        foreach (Car car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }
    }
}