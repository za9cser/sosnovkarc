using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SosnovkaRC.Repository;
using SosnovkaRC.Repository.Repositories;

namespace SosnovkaRC.DependecyUtils;

public static class RegisterCommonServices
{
    public static void RegisterCommon(this IServiceCollection services, IConfiguration configuration, string environmentName)
    {
        AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        AppContext.SetSwitch("Npgsql.EnableLegacyCaseInsensitiveDbParameters", true);

        // repository
        services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
    }
}