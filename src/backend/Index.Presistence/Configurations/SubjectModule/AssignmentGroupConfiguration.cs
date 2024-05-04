namespace Index.Presistence.Configurations.SubjectModule;

public class AssignmentGroupConfiguration : IEntityTypeConfiguration<AssignmentGroup>
{
    public void Configure(EntityTypeBuilder<AssignmentGroup> builder)
    {
        builder.ToTable("AssignmentGroups", "sub");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(x => x.SubjectCode)
            .IsRequired()
            .HasMaxLength(8);

        builder.Property(x => x.DateCreated)
            .HasDefaultValue(DateTime.Now)
            .IsRequired();

        builder.Property(x => x.DateModified)
            .HasDefaultValue(null);

        builder.Property(x => x.TotalAssignments)
            .IsRequired()
            .ValueGeneratedNever();

        builder.Property(x => x.UserProfileId)
            .IsRequired();

        builder.HasOne(x => x.UserProfile)
            .WithMany(x => x.AssignmentGroups)
            .HasForeignKey(x => x.UserProfileId)
            .HasPrincipalKey(x => x.Id);

        builder.HasOne(x => x.Subject)
            .WithMany(x => x.AssignmentGroups)
            .HasForeignKey(x => x.SubjectCode)
            .HasPrincipalKey(x => x.SubjectCode);

        builder.HasMany(x => x.Assignments)
            .WithOne(x => x.AssignmentGroup)
            .HasForeignKey(x => x.AssignmentGroupId)
            .HasPrincipalKey(x => x.Id);
    }
}