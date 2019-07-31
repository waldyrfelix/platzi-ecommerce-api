using Microsoft.EntityFrameworkCore;
using Platzi.Ecom.Core.Orders;
using System.Linq;

namespace Platzi.Ecom.Data
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(DbContext dbContext) : base(dbContext)
        {
        }

        public override Order GetById(int id)
        {
            return dbContext.Set<Order>()
                .Include(o => o.Customer)
                .Include(o => o.Items)
                .Where(x => x.Id == id && x.Deleted == false)
                .First();
        }
    }
}
