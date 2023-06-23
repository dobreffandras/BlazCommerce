using Microsoft.EntityFrameworkCore;
namespace BlazCommerce.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }

    public virtual DbSet<ProductEntity> Products { get; set;  }
}
