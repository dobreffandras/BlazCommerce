using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazCommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return Ok(new[]
            {
                new Product(){ Id = 1, Name = "Product1" },
                new Product(){ Id = 2, Name = "Product2" },
                new Product(){ Id = 3, Name = "Product3" },
                new Product(){ Id = 4, Name = "Product4" },
            });
        }
    }
}
