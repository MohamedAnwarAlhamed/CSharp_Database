
internal class CoporateConfiguration : IEntityTypeConfiguration<Coporate>
{
    public void Configure(EntityTypeBuilder<Coporate> builder)
    {
        builder.ToTable("Coporates");
    }
}

