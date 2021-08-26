using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMCWebServices.DataAccess;
using SMCWebServices.DataAccess.Domain;
using System.Linq;

namespace SMCWebServices.Controllers
{

    public class ShoppingCartCriteria
    {
        public int OrderId { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ILogger<ShoppingCartController> _logger;

        private SmcContext _context;

        public ShoppingCartController(ILogger<ShoppingCartController> logger, SmcContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public ShoppingCart Get(ShoppingCartCriteria scc)
        {
            Order order = GetOrder(scc.OrderId);

            return new ShoppingCart(order);
        }

        [HttpPost("CancelOrder")]
        public Response CancelOrder([FromBody] ShoppingCartCriteria scc)
        {
            Order order = GetOrder(scc.OrderId);
            Response response = new Response(scc.OrderId);

            if (order == null)
            {
                response.Message = string.Format("Order {0} is not valid. No orders found.", scc.OrderId);
            }
            else if (order.Status == "Shipped")
            {
                response.Message = string.Format("Order {0} has already shipped and cannot be cancelled", scc.OrderId);
            }
            else if (order.Status == "Cancelled")
            {
                response.Message = string.Format("Order {0} has already been cancelled", scc.OrderId);
            }
            else 
            {
                order.Status = "Cancelled";
                _context.SaveChanges();
                response.Success = true;
                response.Message = string.Format("Order {0} has been cancelled", scc.OrderId);
            }

            return response;
        }

        private Order GetOrder(int orderId)
        {
            var details = _context.OrderDetails.ToList();
            var products = _context.Products.ToList();
            var order = _context.Orders.Where(o => o.OrderId == orderId).FirstOrDefault();

            return order;
        }

    }
}
