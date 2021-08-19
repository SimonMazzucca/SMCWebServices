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
            var details = _context.OrderDetails.ToList();
            var order = _context.Orders.Where(o => o.OrderId == scc.OrderId).FirstOrDefault();

            return new ShoppingCart(order);
        }
    }
}
