﻿
public class EnrollmentConfiguration : IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.HasKey(x => new { x.SectionId, x.StudentId });

        builder.ToTable("Enrollments");
    }
}

