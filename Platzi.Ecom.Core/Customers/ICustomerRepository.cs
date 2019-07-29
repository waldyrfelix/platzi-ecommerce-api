using Platzi.Ecom.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Customers
{
    public interface ICustomerRepository : IRepositoryBase<Customer>
    {
        Customer GetByCPF(string cpf);
    }
}
