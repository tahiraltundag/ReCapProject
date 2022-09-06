using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface ColorService
{
    IDataResult<List<Color>> GetAll(); 
    IDataResult<List<Color>> GetById(int id);
    IResult Add(Color color);
    IResult Update(Color color); 
    IResult Delete(Color color);
    
    
}