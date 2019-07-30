using System;
using Microsoft.AspNetCore.Mvc;
using Platzi.Ecom.Core.Orders;

namespace Platzi.Ecom.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService orderService;
        private readonly IOrderRepository orderRepository;

        public OrdersController(IOrderService orderService, IOrderRepository orderRepository)
        {
            this.orderService = orderService;
            this.orderRepository = orderRepository;
        }

        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            try
            {
                return Ok(orderRepository.GetById(id));
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, details = e.StackTrace });
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] OrderModel orderModel)
        {
            try
            {
                var order = orderService.PlaceOrder(orderModel.CustomerId, orderModel.Products);

                return Ok(order);
            }
            catch (Exception e)
            {
                return BadRequest(new { message = e.Message, details = e.StackTrace });
            }
        }
    }
}