using SQLQuery;
using System.Collections.Generic;
using System.Reflection.Emit;

using (AbstractDbContext context = new())
{
    var result = context.Products
        .SelectMany(p => p.ProductCategories.DefaultIfEmpty(), (p, pc) => new { Product = p, ProductCategory = pc })
        .Select(x => new
        {
            ProductName = x.Product.ProductName,
            CategoryName = x.ProductCategory != null ? x.ProductCategory.Category.CategoryName : "Без категории"
        })
        .ToList();

    foreach (var item in result)
    {
        Console.WriteLine($"{item.ProductName} - {item.CategoryName}");
    }
}