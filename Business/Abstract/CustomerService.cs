using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract;

public interface CustomerService
{
    IDataResult<List<Customer>> GetAll();
    IDataResult<List<Customer>> GetById(int Id);
    IResult Add(Customer customer);
    IResult Delete(Customer customer);
    IResult Update(Customer customer);
}