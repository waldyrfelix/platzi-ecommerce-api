using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Data
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public Customer GetByCPF(string cpf)
        {
            return null;
        }
    }
}
