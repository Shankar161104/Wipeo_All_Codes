using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wipro_API_DFA_27_08_2024.Repository;
using Wipro_API_DFA_27_08_2024.Models;

namespace Wipro_API_DFA_27_08_2024.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository orderRepository;

        public OrderController(IOrderRepository _orderRepository)
        {
            orderRepository = _orderRepository;
        }

        [HttpPost("Place Order")]
        public ActionResult CreateOrder(Order order)
        {
            return Ok(orderRepository.CreateOrder(order));
        }

        [HttpGet("ShowOrders")]
        public ActionResult GetAllOrders(Order order)
        {
            return Ok(orderRepository.GetAllOrders());
        }

        [HttpGet("ShowOrderByID")]

        public ActionResult SearchOrder(int OrderID)
        {
            return Ok(orderRepository.SearchOrder(OrderID));
        }


        [HttpDelete("DeleteProduct")]
        public ActionResult DeleteProduct(int orderId)
        {
            return Ok(orderRepository.DeleteOrder(orderId));
        }

    }
}
