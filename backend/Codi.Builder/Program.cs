using Codi.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();
builder.Services.AddHostedService<Builder>();
builder.WebHost.UseUrls("http://*:5090");

var app = builder.Build();

app.MapHealthChecks("/health");

app.Run();