using BlazCommerce.Server.Services;

namespace BlazCommerce
{
    public static class WebApplicationBuilderExtensions
    {
        public static void ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddScoped<IProductsService, ProductsService>();
        }
    }
}
