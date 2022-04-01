using Codi.Core.DAL.NoSql.Context;
using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Repositories;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Codi.Core.DAL.NoSql.Settings;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson.Serialization.Conventions;
using Microsoft.AspNetCore.Builder;
using Codi.Core.DAL.NoSql.Seed;
using MongoDB.Driver;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson;

namespace Codi.Core.DAL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCodiCoreContext(configuration);
            services.AddCodiFileStorage(configuration);
        }

        public static void AddCodiCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration["ConnectionStrings:CodiCoreDBConnection"];

            services.AddDbContext<CodiCoreContext>(options =>
                options.UseSqlServer(
                    connectionsString,
                    opt => opt.MigrationsAssembly(typeof(CodiCoreContext).Assembly.GetName().Name)));
        }

        public static void AddCodiFileStorage(this IServiceCollection services, IConfiguration configuration)
        {
            ConventionRegistry.Register(nameof(CamelCaseElementNameConvention), new ConventionPack { new CamelCaseElementNameConvention() }, _ => true);
            ConventionRegistry.Register(nameof(IgnoreIfNullConvention), new ConventionPack { new IgnoreIfNullConvention(true) }, _ => true);
            BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;
            BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

            services.Configure<CodiFileStorageSettings>(configuration.GetSection("FileStorageDatabase"));
            services.AddSingleton<IMongoContext, CodiFileStorageContext>();


            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<ITemplateRepository, TemplateRepository>();
            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<IAppRepository, AppRepository>();
        }

        public static IApplicationBuilder MigrateDB(this IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            using var context = scope?.ServiceProvider.GetRequiredService<CodiCoreContext>();
            context?.Database.Migrate();

            return builder;
        }

        public static async Task<IApplicationBuilder> SeedFileStorageData(this IApplicationBuilder builder)
        {
            using var scope = builder.ApplicationServices.GetService<IServiceScopeFactory>()?.CreateScope();
            if (scope == null) return builder;

            var context = scope.ServiceProvider.GetRequiredService<IMongoContext>();
            var collectionNames = await context.Database.ListCollectionNames().ToListAsync();

            var fileRepository = scope.ServiceProvider.GetRequiredService<IFileRepository>();
            var templateRepository = scope.ServiceProvider.GetRequiredService<ITemplateRepository>();

            if (!collectionNames.Any())
            {
                var projectRepository = scope.ServiceProvider.GetRequiredService<IProjectRepository>();
                var appRepository = scope.ServiceProvider.GetRequiredService<IAppRepository>();
                using var codeCoreContext = scope.ServiceProvider.GetRequiredService<CodiCoreContext>();

                await CodiFileStorageSeed.SeedData(codeCoreContext, fileRepository, 
                    templateRepository, projectRepository, appRepository);
            }
            else
            {
                await CodiFileStorageSeed.EnsureTemplatesSeeded(fileRepository, templateRepository);
            }

            return builder;
        }
    }
}
