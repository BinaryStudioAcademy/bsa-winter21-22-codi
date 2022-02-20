using Codi.Core.WebAPI.Extentions;
using Codi.Core.DAL;
using Codi.Core.WebAPI.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.ConfigureDALServices(builder.Configuration);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.RegisterCustomServices();
builder.Services.AddAutoMapper();
builder.Services.AddSwaggerGen();
builder.Services.AddValidation();
builder.Services.RegisterRabbitMQ(builder.Configuration);
builder.Services.ServiceJwtFirebase(builder.Configuration);
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<GenericExceptionHandlerMiddleware>();

app.MigrateDB();
await app.SeedFileStorageData();

app.UseCors(opt => opt
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
