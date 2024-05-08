namespace Index.Presistence.Configurations.SubjectModule;

internal class StudyPlanConfiguration : IEntityTypeConfiguration<StudyPlan>
{
    public void Configure(EntityTypeBuilder<StudyPlan> builder)
    {
        builder.ToTable("StudyPlans", "sub");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();

        builder.Property(x => x.DateCreated)
            .IsRequired();

        builder.Property(x => x.UserProfileId)
            .IsRequired()
            .ValueGeneratedNever();

        builder.HasMany(p => p.StudyPlanRestrictions)
            .WithOne(d => d.StudyPlan)
            .HasPrincipalKey(p => p.Id)
            .HasForeignKey(d => d.StudyPlanId)
            .OnDelete(DeleteBehavior.ClientCascade);

        builder.HasMany(p => p.StudyPlanSubjects)
            .WithOne(d => d.StudyPlan)
            .HasForeignKey(d => d.StudyPlanId)
            .HasPrincipalKey(p => p.Id)
            .OnDelete(DeleteBehavior.ClientCascade);
    }
}