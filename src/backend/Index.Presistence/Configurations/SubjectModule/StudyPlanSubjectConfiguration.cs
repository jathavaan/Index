namespace Index.Presistence.Configurations.SubjectModule;

internal class StudyPlanSubjectConfiguration : IEntityTypeConfiguration<StudyPlanSubject>
{
    public void Configure(EntityTypeBuilder<StudyPlanSubject> builder)
    {
        builder.ToTable("StudyPlanSubjects", "sub");
        builder.HasKey(x => new { x.SubjectCode, x.StudyPlanId });

        builder.HasOne(d => d.StudyPlan)
            .WithMany(p => p.StudyPlanSubjects)
            .HasPrincipalKey(p => p.Id)
            .HasForeignKey(d => d.StudyPlanId);

        builder.HasOne(d => d.Subject)
            .WithMany(p => p.StudyPlanSubjects)
            .HasPrincipalKey(p => p.SubjectCode)
            .HasForeignKey(d => d.SubjectCode);
    }
}