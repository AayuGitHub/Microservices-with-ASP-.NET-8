using Microsoft.AspNetCore.Mvc;
using OrderService.Core.Repositories;

namespace OrderService.API.Controllers
{
    [ApiController]
    [Route("api/orders")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrdersController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        //[HttpPost]
        //public IActionResult CreateOrder
    }
}
