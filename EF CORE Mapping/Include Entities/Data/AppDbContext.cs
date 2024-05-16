﻿
public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .ToTable("Products", schema: "Inventory")
            .HasKey(x => x.Id);

        modelBuilder.Entity<OrderDetail>()
          .ToTable("OrderDetails", schema: "Sales")
          .HasKey(x => x.Id);

        modelBuilder.Entity<AuditEntry>()
            .HasKey(x => x.Id);

        base.OnModelCreating(modelBuilder);

    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

        var constr = configuration.GetSection("constr").Value;

        optionsBuilder.UseSqlServer(constr);
    }
}
