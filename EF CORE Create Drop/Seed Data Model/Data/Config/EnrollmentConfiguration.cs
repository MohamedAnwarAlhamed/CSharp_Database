
public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.HasKey(x => new { x.SectionId, x.ParticipantId });

        builder.ToTable("Enrollments");
        builder.HasData(SeedData.LoadEnrollments());
    }
}

