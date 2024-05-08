namespace Index.Presistence.Configurations.SubjectModule;

internal class ReportCardConfiguration : IEntityTypeConfiguration<ReportCard>
{
    public void Configure(EntityTypeBuilder<ReportCard> builder)
    {
        builder.HasKey(x => x.Id);
        builder.ToTable("ReportCards", "sub");

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.Name)
            .IsRequired();

        builder.Property(x => x.DateCreated)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(x => x.UserProfileId)
            .IsRequired()
            .ValueGeneratedNever();

        builder.HasMany(x => x.ReportCardSubjects)
            .WithOne(x => x.ReportCard)
            .HasForeignKey(x => x.ReportCardId)
            .HasPrincipalKey(x => x.Id)
            .IsRequired();
    }
}