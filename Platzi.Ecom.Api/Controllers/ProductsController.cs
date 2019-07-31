using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platzi.Ecom.Core.Common;
using Platzi.Ecom.Core.Products;

namespace Platzi.Ecom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepositoryBase<Product> productRepository;
        private readonly IProductService productService;

        public ProductsController(IRepositoryBase<Product> productRepository, 
            IProductService productService)
        {
            this.productRepository = productRepository;
            this.productService = productService;
        }

        [HttpGet]
        public ActionResult Get()
        {
            return Ok(productRepository.GetAll());
        }

        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(int id)
        {
            return Ok(productRepository.GetById(id));

        }

        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            productService.Create(product);
            return Ok(product);
        }
    }
}
