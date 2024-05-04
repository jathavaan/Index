namespace Index.Presistence.Configurations.SubjectModule;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(x => x.SubjectCode);
        builder.ToTable("Subjects", "sub");

        builder.Property(x => x.SubjectCode)
            .IsRequired()
            .ValueGeneratedNever()
            .HasMaxLength(8);

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.Credits)
            .IsRequired();

        builder.HasMany(x => x.ReportCardSubjects)
            .WithOne(x => x.Subject)
            .HasForeignKey(x => x.SubjectCode)
            .HasPrincipalKey(x => x.SubjectCode)
            .IsRequired();
    }
}