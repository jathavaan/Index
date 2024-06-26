﻿namespace Index.Presistence.Configurations.SubjectModule;

internal class ReportCardSubjectConfiguration : IEntityTypeConfiguration<ReportCardSubject>
{
    public void Configure(EntityTypeBuilder<ReportCardSubject> builder)
    {
        builder.ToTable("ReportCardSubjects", DatabaseSchema.Subject);
        builder.HasKey(x => new { x.ReportCardId, x.SubjectCode, x.Year });

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