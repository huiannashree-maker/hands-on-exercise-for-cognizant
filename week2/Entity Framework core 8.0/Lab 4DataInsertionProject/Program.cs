using var context = new AppDbContext();
var electronics = new Category { Name = "Electronics" };
var groceries = new Category { Name = "Groceries" };

await context.Categories.AddRangeAsync(electronics, groceries);
var p1 = new Product { Name = "Laptop", Price = 75000, Category = electronics };
var p2 = new Product { Name = "Rice Bag", Price = 1200, Category = groceries };

await context.Products.AddRangeAsync(p1, p2);
await context.SaveChangesAsync();