using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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
    
    public IDataResult<List<Color>> GetAll()
    {
        return new SuccessDataResult<List<Color>>(colorDal.GetAll(), Messages.ColorListed);
    }

    public IDataResult<List<Color>> GetById(int id)
    {
        return new SuccessDataResult<List<Color>>(colorDal.GetAll(c => c.Id == id).ToList(), Messages.GetByColorId);
    }

    public IResult Add(Color color)
    {
        colorDal.Add(color);
        return new SuccessResult(Messages.ColorAdded);
    }

    public IResult Update(Color color)
    {
        colorDal.Update(color);
        return new SuccessResult(Messages.ColorUpdate);
    }

    public IResult Delete(Color color)
    {
        colorDal.Delete(color);
        return new SuccessResult(Messages.ColorDeleted);
    }
}