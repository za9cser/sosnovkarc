using Microsoft.EntityFrameworkCore;

namespace SosnovkaRC.Repository;

public class SosnovkaContext : DbContext
{
    public SosnovkaContext(DbContextOptions options) : base(options)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
    }
}