using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Customers;

namespace Platzi.Ecom.Data
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext) { }

        public Customer GetByCPF(string cpf)
        {
            return null;
        }
    }
}
