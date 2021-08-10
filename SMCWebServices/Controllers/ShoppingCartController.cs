using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMCWebServices.DataAccess;
using SMCWebServices.DataAccess.Domain;
using System.Linq;

namespace SMCWebServices.Controllers
{
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
        public ShoppingCart Get()
        {
            var test = _context.Orders.ToList();

            return new ShoppingCart();
        }
    }
}
