using Microsoft.EntityFrameworkCore;
using SosnovkaRC.Domain.Models;

namespace SosnovkaRC.Repository;

public class SosnovkaContext : DbContext
{
    public DbSet<Athlete> Athletes { get; set; } = null!;

    public SosnovkaContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}