using Platzi.Ecom.Core.Customers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository repository;

        public CustomerService(ICustomerRepository repository)
        {
            this.repository = repository;
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

            repository.Insert(customer);
        }
    }
}
