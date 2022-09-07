using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete;

public class CustomerManager : CustomerService
{
    CustomerDal customerDal;

    public CustomerManager(CustomerDal customerDal)
    {
        this.customerDal = customerDal;
    }
    
    public IDataResult<List<Customer>> GetAll()
    {
        return new SuccessDataResult<List<Customer>>(customerDal.GetAll(), Messages.CustomerListed);
    }

    public IDataResult<List<Customer>> GetById(int id)
    {
        return new SuccessDataResult<List<Customer>>(customerDal.GetAll(c => c.Id == id));
    }

    public IResult Add(Customer customer)
    {
        customerDal.Add(customer);
        return new SuccessResult(Messages.CustomerAdded);
    }

    public IResult Delete(Customer customer)
    {
        customerDal.Delete(customer);
        return new SuccessResult(Messages.CustomerDeleted);
    }

    public IResult Update(Customer customer)
    {
        customerDal.Update(customer);
        return new SuccessResult(Messages.CustomerUpdated);
    }
}






