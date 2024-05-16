public class SectionDetailsConfiguration : IEntityTypeConfiguration<SectionDetails>
{
    public void Configure(EntityTypeBuilder<SectionDetails> builder)
    {
        builder.HasNoKey();
    }
}

public class CourseOverviewConfiguration : IEntityTypeConfiguration<CourseOverview>
{
    public void Configure(EntityTypeBuilder<CourseOverview> builder)
    {
        builder.HasNoKey();
        builder.ToView("CourseOverview");
    }
}

