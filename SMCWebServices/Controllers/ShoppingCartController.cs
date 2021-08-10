using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMCWebServices.DataAccess.Domain;

namespace SMCWebServices.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ShoppingCartController : ControllerBase
    {
        private readonly ILogger<ShoppingCartController> _logger;

        public ShoppingCartController(ILogger<ShoppingCartController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ShoppingCart Get()
        {
            //var test = ContextManager.Context.Orders.ToList();

            return new ShoppingCart();
        }
    }
}
