﻿using Microsoft.EntityFrameworkCore;
namespace BlazCommerce.Server.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options) { }

    public DbSet<Product> Products { get; }
}
