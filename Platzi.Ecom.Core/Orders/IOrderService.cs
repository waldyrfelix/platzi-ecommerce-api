using System.Collections.Generic;

namespace Platzi.Ecom.Core.Orders
{
    public interface IOrderService
    {
        Order PlaceOrder(int customerId, ICollection<int> productIds);
    }
}