using Platzi.Ecom.Core.Common;

namespace Platzi.Ecom.Core.Products
{
    public class Category : IEntity
    {
        public int Id { get; private set; }

        public string Name { get; set; }

        public bool Deleted { get; private set; }
    }
}