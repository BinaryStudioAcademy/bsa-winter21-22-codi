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

namespace Codi.Core.DAL
{
    public static class ConfigurationExtensions
    {
        public static void ConfigureDALServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddCodiCoreContext(configuration);
            services.AddCodiFileStorage(configuration);
        }

        private static void AddCodiCoreContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionsString = configuration["ConnectionStrings:CodiCoreDBConnection"];

            services.AddDbContext<CodiCoreContext>(options =>
                options.UseSqlServer(
                    connectionsString,
                    opt => opt.MigrationsAssembly(typeof(CodiCoreContext).Assembly.GetName().Name)));
        }

        private static void AddCodiFileStorage(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<CodiFileStorageSettings>(configuration.GetSection("FileStorageDatabase"));

            services.AddSingleton<IMongoContext, CodiFileStorageContext>();

            ConventionRegistry.Register(nameof(CamelCaseElementNameConvention), new ConventionPack { new CamelCaseElementNameConvention() }, _ => true);
            ConventionRegistry.Register(nameof(IgnoreIfNullConvention), new ConventionPack { new IgnoreIfNullConvention(true) }, _ => true);

            services.AddScoped<IFileRepository, FileRepository>();
            services.AddScoped<ITemplateRepository, TemplateRepository>();
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

            if (!collectionNames.Any())
            {
                var fileRepository = scope.ServiceProvider.GetRequiredService<IFileRepository>();
                var templateRepository = scope.ServiceProvider.GetRequiredService<ITemplateRepository>();

                await CodiFileStorageSeed.SeedData(fileRepository, templateRepository);
            }

            return builder;
        }
    }
}
