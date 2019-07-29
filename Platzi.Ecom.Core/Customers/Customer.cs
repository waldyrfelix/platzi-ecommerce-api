using Platzi.Ecom.Core.Common;
using System;

namespace Platzi.Ecom.Core.Customers
{
    public class Customer : IEntity
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }

        public string CPF { get; private set; }

        public bool Deleted { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public DateTime UpdatedAt { get; private set; }
    }
}
