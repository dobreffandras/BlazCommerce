namespace BlazCommerce.Server.Services;

public interface IProductsService
{
    Task<Product> CreateServiceAsync(NewProduct newProduct);
    Task<IEnumerable<Product>> GetProducts();
}
