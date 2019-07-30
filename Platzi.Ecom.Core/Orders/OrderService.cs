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
        private readonly IRepositoryBase<Order> orderRepository;
        private readonly IUnitOfWork unitOfWork;
        private readonly ICustomerRepository customerRepository;

        public OrderService(ICustomerRepository customerRepository, 
            IRepositoryBase<Product> productRepository,
            IRepositoryBase<Order> orderRepository,
            IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.orderRepository = orderRepository;
            this.unitOfWork = unitOfWork;
            this.customerRepository = customerRepository;
        }

        public Order PlaceOrder(int customerId, ICollection<int> productIds)
        {
            if (productIds == null)
            {
                throw new ArgumentNullException(nameof(productIds));
            }

            if (productIds.Count == 0)
            {
                throw new InvalidOperationException("Não é permitido fechar um pedido sem produtos associados.");
            }

            var customer = customerRepository.GetById(customerId);

            var order = new Order();
            foreach (var id in productIds)
            {
                var existingProduct = productRepository.GetById(id);

                var orderItem = new OrderItem();
                orderItem.CopyFromProduct(existingProduct);

                order.Items.Add(orderItem);
            }

            order.AssociateCustomer(customer);
            order.CalculateTotalValue();

            using (unitOfWork)
            {
                orderRepository.Insert(order);
            }

            return order;
        }
    }
}
