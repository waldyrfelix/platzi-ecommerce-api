using System;
using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Products;

namespace Platzi.Ecom.Core.Orders
{
    public class OrderItem : IEntity
    {
        public int Id { get; private set; }

        public bool Deleted { get; private set; }

        public string Description { get; set; }

        public decimal Value { get; set; }

        public Product ProductReference { get; set; }

        public void CopyFromProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }

            ProductReference = product;
            Value = product.Value;
            Description = product.Description;
        }
    }
}