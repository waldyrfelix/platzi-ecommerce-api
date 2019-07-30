using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Platzi.Ecom.Core.Orders
{
    public class Order : IEntity
    {
        public Order()
        {
            Items = new List<OrderItem>();
            OrderStatus = OrderStatus.Placed;
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }

        #region Methods

        public void CalculateTotalValue()
        {
            TotalValue = Items.Sum(i => i.Value);
        }

        public void AssociateCustomer(Customer customer)
        {
            this.Customer = customer;
            this.DeliveryAddress = customer.Address;
        }

        public void ChangePaymentToPending()
        {
            if (OrderStatus != OrderStatus.Placed && OrderStatus != OrderStatus.PaymentRejected)
                throw new InconsistentOrderStatusException($"O status {OrderStatus.PaymentPending} é inválido para o status atual do pedido. ({OrderStatus}).");

            OrderStatus = OrderStatus.PaymentPending;
        }

        public void ChangePaymentToApproved()
        {
            if (OrderStatus != OrderStatus.PaymentPending)
                throw new InconsistentOrderStatusException($"O status {OrderStatus.PaymentApproved} é inválido para o status atual do pedido. ({OrderStatus}).");

            OrderStatus = OrderStatus.PaymentApproved;
        }

        public void ChangePaymentToInvoiced()
        {
            if (OrderStatus != OrderStatus.PaymentApproved)
                throw new InconsistentOrderStatusException($"O status {OrderStatus.Invoiced} é inválido para o status atual do pedido. ({OrderStatus}).");

            OrderStatus = OrderStatus.Invoiced;
        }
        
        #endregion

        public int Id { get; private set; }

        public OrderStatus OrderStatus { get; private set; }

        public decimal TotalValue { get; set; }

        public Customer Customer { get; private set; }

        public ICollection<OrderItem> Items { get; private set; }

        public string DeliveryAddress { get; private set; }

        public bool Deleted { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
