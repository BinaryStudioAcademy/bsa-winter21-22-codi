using Codi.Notifier.WebAPI.RabbitMQ;
using Codi.Notifier.WebAPI.RabbitMQ.Abstract;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using Codi.RabbitMQ.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using RabbitMQ.Client;

namespace Codi.Notifier.WebAPI.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterRabbitMQ(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConnectionFactory>(x => new ConnectionFactory()
        {
            Uri = new Uri(configuration.GetSection("Rabbit").Value)
        });
        services.AddSingleton<IMessageConsumerScopeFactory, MessageConsumerScopeFactory>();

        var projectOutputSettings = configuration
            .GetSection("Queues:ProjectOutputQueue")
            .Get<MessageScopeSettings>();

        services.AddSingleton<IOutputConsumer>(provider =>
            new OutputConsumer(
                provider.GetRequiredService<IMessageConsumerScopeFactory>(),
                projectOutputSettings));
    }

    public static void ServiceJwtFirebase(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
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

                options.Events = new JwtBearerEvents
                {
                    OnMessageReceived = context =>
                    {
                        var accessToken = context.Request.Query["access_token"];

                        var path = context.HttpContext.Request.Path;
                        if (!string.IsNullOrEmpty(accessToken) &&
                            path.StartsWithSegments("/buildHub"))
                        {
                            context.Token = accessToken;
                        }
                        return Task.CompletedTask;
                    }
                };
            });
    }
}

