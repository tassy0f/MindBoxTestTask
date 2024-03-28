using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

namespace SQLQuery;

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; }
}

public class Category
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public ICollection<ProductCategory> ProductCategories { get; set; }
}

public class ProductCategory
{
    public int ProductID { get; set; }
    public Product Product { get; set; }
    public int CategoryID { get; set; }
    public Category Category { get; set; }
}
public class AbstractDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductCategory> ProductCategories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductCategory>()
            .HasKey(pc => new { pc.ProductID, pc.CategoryID });
    }
}
