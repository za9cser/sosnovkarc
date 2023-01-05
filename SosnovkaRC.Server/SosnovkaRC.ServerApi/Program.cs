using Microsoft.EntityFrameworkCore;
using SosnovkaRC.DependecyUtils;
using SosnovkaRC.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment;
var services = builder.Services;
var configuration = new ConfigurationBuilder()
    .AddConfiguration(builder.Configuration)
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile(Path.Combine(env.ContentRootPath, $"appsettings.{env.EnvironmentName}.json"))
    .AddEnvironmentVariables()
    .Build();
services.AddEntityFrameworkNpgsql().AddDbContext<SosnovkaContext>(options =>
{
    options
        .UseNpgsql(configuration.GetConnectionString("Default"))
        .EnableSensitiveDataLogging();
});
services.RegisterCommon(builder.Configuration, builder.Environment.EnvironmentName);
services.AddControllers().AddNewtonsoftJson();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();