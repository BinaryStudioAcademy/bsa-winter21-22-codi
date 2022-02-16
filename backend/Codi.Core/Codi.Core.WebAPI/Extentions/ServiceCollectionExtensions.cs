using Codi.Core.BL.Interfaces;
using Codi.Core.BL.MappingProfiles;
using Codi.Core.BL.Services;
using FluentValidation.AspNetCore;
using System.Reflection;
using Codi.Core.BLL.RabbitMQ;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using Codi.RabbitMQ.Services;
using RabbitMQ.Client;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;


namespace Codi.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<ISampleService, SampleService>();
        }

        public static void AddAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetAssembly(typeof(SampleProfile)));
        }

        public static void AddValidation(this IServiceCollection services)
        {
            services
                .AddControllers()
                .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<NewSampleDtoValidator>());
        }

        public static void RegisterRabbitMQ(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSingleton<IConnectionFactory>(x => new ConnectionFactory()
            {
                Uri = new Uri(configuration.GetSection("Rabbit").Value)
            });
            services.AddSingleton<IMessageProducerScopeFactory, MessageProducerScopeFactory>();
            services.AddSingleton<IMessageConsumerScopeFactory, MessageConsumerScopeFactory>();

            var messageSettings = new MessageScopeSettings();
            configuration
                .GetSection("Queues:ExampleQueue")
                .Bind(messageSettings);
            services.AddScoped<IMessageService>(provider =>
                new MessageService(
                    provider.GetRequiredService<IMessageProducerScopeFactory>(),
                    messageSettings));
        }

        public static void ServiceJwtFirebase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = configuration["Jwt:Firebase:ValidIssuer"];
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidIssuer = configuration["Jwt:Firebase:ValidIssuer"],
                        ValidateAudience = true,
                        ValidAudience = configuration["Jwt:Firebase:ValidAudience"],
                        ValidateLifetime = true
                    };
                });
        }
    }
}
