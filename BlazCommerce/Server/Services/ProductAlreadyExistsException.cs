namespace BlazCommerce.Server.Services;

[Serializable]
internal class ProductAlreadyExistsException : Exception
{
    public ProductAlreadyExistsException(string productName)
        : base($"Product already exists with the name {productName}")
    {
    }
}