namespace Index.Presistence.Configurations.SubjectModule;

public class SubjectConfiguration : IEntityTypeConfiguration<Subject>
{
    public void Configure(EntityTypeBuilder<Subject> builder)
    {
        builder.HasKey(x => x.Id);
        builder.ToTable("Subject", "sub");

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.SubjectCode)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.Credit)
            .IsRequired();

        builder.HasMany(x => x.ReportCardSubjects)
            .WithOne(x => x.Subject)
            .HasForeignKey(x => x.SubjectId)
            .HasPrincipalKey(x => x.Id)
            .IsRequired();
    }
}