
using Microsoft.EntityFrameworkCore;

public class WalksDbContext : DbContext
{
    public WalksDbContext(DbContextOptions<WalksDbContext> options) : base(options)
    {
    }

    // Define DbSets for your entities here
    // public DbSet<YourEntity> YourEntities { get; set; }

    public DbSet<Difficulty> Difficulties { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<Walk> Walks { get; set; }
}