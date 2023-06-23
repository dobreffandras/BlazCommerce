using BlazCommerce.Shared;
using System.Net.Http.Json;

namespace BlazCommerce.Client.Services;

public class ProductsService
{
    private readonly HttpClient httpClient;

    public ProductsService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }
    public Task<Product[]> GetProducts()
    {
        return httpClient.GetFromJsonAsync<Product[]>("api/products");
    }

    public async Task CreateProduct(NewProduct newProduct)
    {
        await httpClient.PostAsJsonAsync("api/products", newProduct);
    }
}
