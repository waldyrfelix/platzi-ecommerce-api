using System.Collections.Generic;
using Platzi.Ecom.Core.Customers;
using Platzi.Ecom.Core.Products;

namespace Platzi.Ecom.Core.Orders
{
    public interface IOrderService
    {
        Order PlaceOrder(Customer customer, ICollection<int> productIds);
    }
}