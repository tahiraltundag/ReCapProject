using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;

namespace DataAccess.Abstract;

public interface RentalDal : EntityRepository<Rental>
{
    
}