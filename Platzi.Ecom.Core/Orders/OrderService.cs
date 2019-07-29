using System;
using System.Collections.Generic;
using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Customers;
using Platzi.Ecom.Core.Products;

namespace Platzi.Ecom.Core.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryBase<Product> productRepository;

        public OrderService(IRepositoryBase<Product> productRepository)
        {
            this.productRepository = productRepository;
        }

        public Order PlaceOrder(Customer customer, ICollection<int> productIds)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            if (productIds == null)
            {
                throw new ArgumentNullException(nameof(productIds));
            }

            if (productIds.Count == 0)
            {
                throw new InvalidOperationException("Não é permitido fechar um pedido sem produtos associados.");
            }

            var order = new Order();
            order.AssociateCustomer(customer);

            foreach (var id in productIds)
            {
                var existingProduct = productRepository.GetById(id);

                var orderItem = new OrderItem();
                orderItem.CopyFromProduct(existingProduct);

                order.Items.Add(orderItem);
            }

            return order;
        }
    }
}
