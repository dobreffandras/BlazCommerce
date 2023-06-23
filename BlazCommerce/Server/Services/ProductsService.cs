using BlazCommerce.Server.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazCommerce.Server.Services
{
    public class ProductsService : IProductsService
    {
        private readonly DataContext dataContext;

        public ProductsService(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public async Task<Product> CreateServiceAsync(NewProduct newProduct)
        {
            if (await dataContext.Products.FirstOrDefaultAsync(e => e.Name.Equals(newProduct.Name)) != null)
                throw new ProductAlreadyExistsException(newProduct.Name);

            var newEntity = new ProductEntity
            {
                Name = newProduct.Name,
                Description = newProduct.Description,
                Category = newProduct.Category,
            };

            await dataContext.Products.AddAsync(newEntity);
            await dataContext.SaveChangesAsync();
            return new Product
            {
                Id = newEntity.Id,
                Name = newEntity.Name,
                Description = newEntity.Description,
                Category = newEntity.Category,
            };
        }
    }
}