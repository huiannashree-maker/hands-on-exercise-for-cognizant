using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

// No 'using Lab_5DataRetrievalProject;' needed if classes are in this folder

var context = new AppDbContext();

// 1. Retrieve All Products
Console.WriteLine("--- All Products ---");
var products = await context.Products.ToListAsync();
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} - ₹{p.Price}");
}

// 2. Find by ID (Retrieving a specific record)
Console.WriteLine("\n--- Find by ID (1) ---");
var product = await context.Products.FindAsync(1);
Console.WriteLine($"Found: {product?.Name ?? "Product not found"}");

// 3. FirstOrDefault with Condition
Console.WriteLine("\n--- Expensive Products (> 5000) ---");
var expensive = await context.Products.FirstOrDefaultAsync(p => p.Price > 5000);
Console.WriteLine($"Expensive: {expensive?.Name ?? "None found"}");