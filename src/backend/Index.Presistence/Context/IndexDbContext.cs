namespace Index.Presistence.Context;

public partial class IndexDbContext(DbContextOptions<IndexDbContext> options) : DbContext(options)
{
    public DbSet<UserProfile> UserProfiles { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IndexDbContext).Assembly);
    }
}