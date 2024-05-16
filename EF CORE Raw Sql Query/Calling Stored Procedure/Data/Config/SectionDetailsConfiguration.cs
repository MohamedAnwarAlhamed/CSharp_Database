public class SectionDetailsConfiguration : IEntityTypeConfiguration<SectionDetails>
{
    public void Configure(EntityTypeBuilder<SectionDetails> builder)
    {
        builder.HasNoKey();
    }
}

