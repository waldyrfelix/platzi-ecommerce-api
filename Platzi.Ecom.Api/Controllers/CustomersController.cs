using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Platzi.Ecom.Core.Customers;

namespace Platzi.Ecom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly ICustomerRepository customerRepository;

        public CustomersController(ICustomerService customerService, ICustomerRepository customerRepository)
        {
            this.customerService = customerService;
            this.customerRepository = customerRepository;
        }

        [HttpGet]
        public ActionResult Get()
        {
            var results = customerRepository.GetAll();

            return Ok(results);
        }

        [HttpPost]
        public ActionResult Post([FromBody]Customer customer)
        {
            if (customer == null)
            {
                return BadRequest();
            }

            customerService.RegisterCustomer(customer);

            return Ok(customer);
        }
    }
}