using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Customers;
using System.Linq;

namespace Platzi.Ecom.Data
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext) { }

        public Customer GetByCPF(string cpf)
        {
            return dbContext.Set<Customer>()
                .Where(x => x.CPF == cpf && x.Deleted == false)
                .FirstOrDefault();
        }
    }
}
