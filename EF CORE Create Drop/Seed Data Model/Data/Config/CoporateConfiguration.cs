
internal class CoporateConfiguration : IEntityTypeConfiguration<Corporate>
{
    public void Configure(EntityTypeBuilder<Corporate> builder)
    {
        builder.ToTable("Coporates");
        builder.HasData(SeedData.LoadCorporates());
    }
}

