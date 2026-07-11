using RetailInventory.Data;
using Microsoft.EntityFrameworkCore;

using var context = new AppDbContext();

var categories = await context.Categories
    .Include(c => c.Products)
    .ToListAsync();

foreach (var category in categories)
{
    Console.WriteLine("Category: " + category.Name);

    foreach (var product in category.Products)
    {
        Console.WriteLine(
            "Product: " + product.Name +
            " Price: " + product.Price
        );
    }
}