namespace Index.Presistence.Configurations.SubjectModule;

internal class StudyPlanRestrictionConfiguration : IEntityTypeConfiguration<StudyPlanRestriction>
{
    public void Configure(EntityTypeBuilder<StudyPlanRestriction> builder)
    {
        builder.ToTable("StudyPlanRestrictions", "sub");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .IsRequired();

        builder.Property(x => x.SubjectType)
            .IsRequired();

        builder.Property(x => x.RequiredCredits)
            .IsRequired();

        builder.Property(x => x.Year)
            .IsRequired();

        builder.Property(x => x.Semester)
            .IsRequired();

        builder.Property(x => x.StudyPlanId)
            .ValueGeneratedNever()
            .IsRequired();

        builder.HasOne(d => d.StudyPlan)
            .WithMany(p => p.StudyPlanRestrictions)
            .HasPrincipalKey(p => p.Id)
            .HasForeignKey(d => d.StudyPlanId);
    }
}