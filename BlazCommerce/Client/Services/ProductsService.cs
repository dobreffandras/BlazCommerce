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
    public async Task<Response<Product[]>> GetProducts()
    {
        try
        {
            var products = await httpClient.GetFromJsonAsync<Product[]>("api/products");
            return Response.Ok(products!);
        } catch (Exception ex) {
            return Response.Fail<Product[]>(ex.Message);
        }
    }

    public async Task<Response<Product>> CreateProduct(NewProduct newProduct)
    {
        

        try
        {
            var res = await httpClient.PostAsJsonAsync("api/products", newProduct);
            var prod = await res.Content.ReadFromJsonAsync<Product>();
            return Response.Ok(prod!);
        }
        catch (Exception ex)
        {
            return Response.Fail<Product>(ex.Message);
        }
    }
}
