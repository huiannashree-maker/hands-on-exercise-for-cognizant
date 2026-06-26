public class Category { public int Id { get; set; } public string Name { get; set; } public List<Product> Products { get; set; } }
public class Product { public int Id { get; set; } public string Name { get; set; } public decimal Price { get; set; } public int CategoryId { get; set; } public Category Category { get; set; } }

public class AppDbContext : DbContext {
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlServer("Your_Connection_String_Here");
}