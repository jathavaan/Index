﻿namespace Index.Presistence.Configurations.SubjectModule;

public class ReportCardSubjectConfiguration : IEntityTypeConfiguration<ReportCardSubject>
{
    public void Configure(EntityTypeBuilder<ReportCardSubject> builder)
    {
        builder.ToTable("ReportCardSubject", "sub");
        builder.HasKey(x => new { x.ReportCardId, SubjectId = x.SubjectCode });

        builder.HasOne(x => x.Subject)
            .WithMany(x => x.ReportCardSubjects)
            .HasPrincipalKey(x => x.SubjectCode)
            .HasForeignKey(x => x.SubjectCode)
            .IsRequired();

        builder.HasOne(x => x.ReportCard)
            .WithMany(x => x.ReportCardSubjects)
            .HasPrincipalKey(x => x.Id)
            .HasForeignKey(x => x.ReportCardId)
            .IsRequired();
    }
}