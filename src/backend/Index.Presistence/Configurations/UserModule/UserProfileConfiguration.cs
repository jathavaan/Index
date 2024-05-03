namespace Index.Presistence.Configurations.UserModule;

public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
{
    public void Configure(EntityTypeBuilder<UserProfile> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .ValueGeneratedNever()
            .IsRequired();

        builder.Property(x => x.FirstName)
            .IsRequired();

        builder.Property(x => x.Surname)
            .IsRequired();

        builder.Property(x => x.Email)
            .IsRequired();

        builder.Property(x => x.Password)
            .IsRequired();

        builder.HasMany(x => x.ReportCards)
            .WithOne(x => x.UserProfile)
            .HasForeignKey(x => x.UserProfileId)
            .HasPrincipalKey(x => x.Id)
            .IsRequired();
    }
}