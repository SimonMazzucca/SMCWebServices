using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SMCWebServices.Domain;

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
            return new ShoppingCart();
        }
    }
}
