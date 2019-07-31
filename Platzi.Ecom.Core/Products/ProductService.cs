using Platzi.Ecom.Core.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Platzi.Ecom.Core.Products
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryBase<Product> productRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IRepositoryBase<Product> productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public void Create(Product product)
        {
            using (unitOfWork)
            {
                productRepository.Insert(product);
            }
        }
    }
}
