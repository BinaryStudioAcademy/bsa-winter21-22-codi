using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.MappingProfiles;
using Codi.Core.BLL.Services;
using FluentValidation.AspNetCore;
using System.Reflection;
using Codi.Core.BLL.RabbitMQ;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using Codi.RabbitMQ.Services;
using RabbitMQ.Client;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Codi.Core.WebAPI.Validators;
using Codi.Core.BLL.RabbitMQ.Abstract;

namespace Codi.Core.WebAPI.Extentions
{
    public static class ServiceCollectionExtensions
    {
        public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
        {
            services
                .AddControllers()
                .AddNewtonsoftJson(options =>
                    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);

            services.AddTransient<ISampleService, SampleService>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IOrganizationService, OrganizationService>();
            services.AddTransient<ICourseService, CourseService>();
            services.AddTransient<ITemplateService, TemplateService>();
            services.AddTransient<IProjectService, ProjectService>();
            services.AddTransient<IAppService, AppService>();
            services.AddTransient<ITagService, TagService>();
            services.AddTransient<IGitService, GitService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IProjectStructureService, ProjectStructureService>();
            services.AddTransient<ICredentialsService, CredentialsService>();
            services.AddTransient<IGithubService, GithubService>();
            services.AddTransient<IUnitService, UnitService>();
            services.AddTransient<ILessonService, LessonService>();
            
            services.AddHttpClient<IGithubClient, GithubClient>(client =>
            {
                client.BaseAddress = new Uri(configuration.GetSection("githubAPI").Value);
                client.DefaultRequestHeaders.UserAgent.TryParseAdd("request");
            });
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

            var messageSettings = configuration
                .GetSection("Queues:ExampleQueue")
                .Get<MessageScopeSettings>();

            services.AddScoped<BLL.RabbitMQ.Abstract.IMessageProducer>((provider =>
                new BLL.RabbitMQ.MessageProducer(
                    provider.GetRequiredService<IMessageProducerScopeFactory>(),
                    messageSettings)));


            var projectRunSettings = configuration
                .GetSection("Queues:RunProjectsQueue")
                .Get<MessageScopeSettings>();

            var projectStopSettings = configuration
                .GetSection("Queues:StopProjectsQueue")
                .Get<MessageScopeSettings>();

            var projectInputSettings = configuration
                .GetSection("Queues:ProjectInputQueue")
                .Get<MessageScopeSettings>();

            services.AddScoped<IBuilderProducer>(provider =>
                new BuilderProducer(
                    provider.GetRequiredService<IMessageProducerScopeFactory>(),
                    projectRunSettings, 
                    projectStopSettings,
                    projectInputSettings));
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
