using Codi.Builder;
using Codi.Builder.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration
    .SetBasePath(builder.Environment.ContentRootPath)
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", reloadOnChange: true, optional: true)
    .AddEnvironmentVariables()
    .Build();

builder.Services.AddHealthChecks();
builder.Services.RegisterCodiFileStorage(builder.Configuration);
builder.Services.RegisterCustomServices(builder.Configuration);
builder.Services.RegisterRabbitMQ(builder.Configuration);
builder.Services.AddHostedService<Builder>();
builder.WebHost.UseUrls("http://*:5090");

var app = builder.Build();

app.MapHealthChecks("/health");

app.Run();