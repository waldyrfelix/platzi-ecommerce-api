using Platzi.Ecom.Core.Common;
using System;

namespace Platzi.Ecom.Core.Customer
{
    public class Customer : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string CPF { get; private set; }
        public bool Deleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
