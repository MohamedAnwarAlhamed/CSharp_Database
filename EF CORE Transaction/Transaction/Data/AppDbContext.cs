public class AppDbContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        var config = new ConfigurationBuilder().AddJsonFile("appsettings.json")
            .Build();

        var connectionString = config.GetSection("constr").Value;

        optionsBuilder.UseSqlServer(connectionString);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }
}

