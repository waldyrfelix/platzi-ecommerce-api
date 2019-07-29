using System;
using Platzi.Ecom.Core.Common;

namespace Platzi.Ecom.Core.Products
{
    public class Product : IEntity
    {
        public int Id { get; private set; }

        public Category Category { get; set; }

        public decimal Value { get; set; }

        public string Description { get; set; }

        public string Photo { get; set; }

        public bool Deleted { get; private set; }
    }
}