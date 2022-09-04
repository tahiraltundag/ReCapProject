using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class ColorManager : ColorService
{
    ColorDal colorDal;

    public ColorManager(ColorDal colorDal)
    {
        this.colorDal = colorDal;
    }
    
    public List<Color> GetAll()
    {
        return colorDal.GetAll();
    }

    public List<Color> GetById(int id)
    {
        return colorDal.GetAll(c => c.Id == id).ToList();
    }

    public void Add(Color color)
    {
        colorDal.Add(color);
    }

    public void Update(Color color)
    {
        colorDal.Update(color);
    }

    public void Delete(Color color)
    {
        colorDal.Delete(color);
    }
}