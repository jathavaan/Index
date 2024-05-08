namespace Index.Presistence.Configurations.SubjectModule;

internal class AssignmentConfiguration : IEntityTypeConfiguration<Assignment>
{
    public void Configure(EntityTypeBuilder<Assignment> builder)
    {
        builder.ToTable("Assignments", "sub");
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(x => x.DateCreated)
            .IsRequired()
            .HasDefaultValue(DateTime.Now);

        builder.Property(x => x.DateModified)
            .HasDefaultValue(null);

        builder.Property(x => x.AssignmentGroupId)
            .IsRequired()
            .ValueGeneratedNever();

        builder.HasOne(x => x.AssignmentGroup)
            .WithMany(x => x.Assignments)
            .HasForeignKey(x => x.AssignmentGroupId)
            .HasPrincipalKey(x => x.Id);
    }
}