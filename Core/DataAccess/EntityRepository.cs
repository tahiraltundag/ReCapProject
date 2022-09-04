using System.Linq.Expressions;
using Core.Entities;

namespace Core.DataAccess;

public interface EntityRepository<T> where T:class,Entity,new()
{
    List<T> GetAll(Expression<Func<T, bool>> filter = null);
    T Get(Expression<Func<T, bool>> filter);
    void Add(T entity);
    void Delete(T entity);
    void Update(T entity);
}