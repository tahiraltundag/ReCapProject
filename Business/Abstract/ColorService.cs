using Entities.Concrete;

namespace Business.Abstract;

public interface ColorService
{
    List<Color> GetAll();
    List<Color> GetById(int id);
    void Add(Color color);
    void Update(Color color);
    void Delete(Color color);
}