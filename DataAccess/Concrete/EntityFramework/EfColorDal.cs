using System.Linq.Expressions;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class EfColorDal : ColorDal
{
    public List<Color> GetAll(Expression<Func<Color, bool>> filter = null)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return filter == null
                ? context.Set<Color>().ToList()
                : context.Set<Color>().Where(filter).ToList();
        }
    }

    public Color Get(Expression<Func<Color, bool>> filter)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            return context.Set<Color>().SingleOrDefault(filter);
        }
    }

    public void Add(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;
            context.SaveChanges();
        }
    }

    public void Delete(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }
    }

    public void Update(Color entity)
    {
        using (NorthwindContext context = new NorthwindContext())
        {
            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}