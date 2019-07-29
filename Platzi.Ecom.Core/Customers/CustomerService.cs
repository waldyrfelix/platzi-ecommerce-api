using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }

        public void RegisterCustomer(Customer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException("customer");
            }

            if(this.repository.GetByCPF(customer.CPF) != null)
            {
                throw new CustomerAlreadyExistsException(customer.Name);
            }

            unitOfWork.InitTransaction();
            repository.Insert(customer);
            unitOfWork.EndTransaction();
        }
    }
}
