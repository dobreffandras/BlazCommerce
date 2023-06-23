using BlazCommerce.Server.Services;
using Microsoft.AspNetCore.Mvc;

namespace BlazCommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

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

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Product>>> CreateProducts(NewProduct newProduct)
        {
            try
            {
                return Ok(await productsService.CreateServiceAsync(newProduct));
            }
            catch (ProductAlreadyExistsException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
