using SosnovkaRC.DependecyUtils;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var env = builder.Environment;
builder.Configuration
    .SetBasePath(env.ContentRootPath)
    .AddJsonFile(Path.Combine(env.ContentRootPath, $"appsettings.{env.EnvironmentName}.json"));
var services = builder.Services;
services.RegisterCommon(builder.Configuration, builder.Environment.EnvironmentName);
services.AddControllers();
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