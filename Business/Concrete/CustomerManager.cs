using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            if (customer.CompanyName != null)
            {
                return new ErrorResult(Messages.CustomerIdInvalid);
            }
            _customerDal.Add(customer);
            return new SuccessResult(Messages.CustomerIsAdded);
        }


        public IResult Delete(Customer customer)
        {
            _customerDal.Delete(customer);
            return new SuccessResult(Messages.CustomerIsDeleted);

        }

        public IDataResult<List<Customer>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Customer>>(Messages.MaintenanceTime);
            }
            else
            {
                return new SuccessDataResult<List<Customer>>(_customerDal.GetAll(), Messages.CustomerListed);
            }
        }

        public IDataResult<Customer> GetById(int customerId)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(cu => cu.CustomerId == customerId));

        }

        public IResult Update(Customer customer)
        {
            if (customer.CustomerId != customer.CustomerId)
            {
                return new ErrorResult(Messages.CustomerIdInvalid);
            }
            _customerDal.Update(customer);
            return new SuccessResult(Messages.CustomerIsUpdated);
        }
    }
}








       


    
