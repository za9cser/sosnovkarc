using Microsoft.EntityFrameworkCore;
using SosnovkaRC.Domain.Models.Athletes;
using SosnovkaRC.Domain.Models.Platforms;
using SosnovkaRC.Domain.Models.Races;

namespace SosnovkaRC.Repository;

public class SosnovkaContext : DbContext
{
    public DbSet<Athlete> Athletes { get; set; } = null!;

    public DbSet<Competition> Competitions { get; set; } = null!;
    public DbSet<Race> Races { get; set; } = null!;
    public DbSet<Run> Runs { get; set; } = null!;
    public DbSet<Result> Results { get; set; } = null!;
    public DbSet<Split> Splits { get; set; } = null!;
    public DbSet<AthleteIdentifier> AthleteIdentifiers { get; set; } = null!;
    public DbSet<Platform> Platforms { get; set; } = null!;

    public SosnovkaContext(DbContextOptions<SosnovkaContext> options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseSerialColumns();
    }
}