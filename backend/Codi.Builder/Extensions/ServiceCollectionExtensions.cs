using Codi.Builder.RabbitMQ;
using Codi.Builder.RabbitMQ.Abstract;
using Codi.RabbitMQ.Interfaces;
using Codi.RabbitMQ.Models;
using Codi.RabbitMQ.Services;
using RabbitMQ.Client;
using Codi.Builder.Interfaces;
using Codi.Builder.Services;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Codi.Core.DAL.NoSql.Settings;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Bson.Serialization;
using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Context;
using Codi.Core.DAL.NoSql.Repositories;
using MongoDB.Bson.Serialization.Serializers;
using Codi.Builder.Services.DockerfileGenerators;

namespace Codi.Builder.Extensions;

public static class ServiceCollectionExtensions
{
    public static void RegisterCustomServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<CSharpDockerfileGenerator>();
        services.AddSingleton<GolangDockerfileGenerator>();
        services.AddSingleton<PythonDockerfileGenerator>();
        services.AddSingleton<FSharpDockerfileGenerator>();

        services.AddSingleton<IProjectBuilderService, ProjectBuilderService>();
        services.AddSingleton<IDockerfileGeneratorFactory, DockerGeneratorFactory>();
        services.AddSingleton<IProjectFilesService, ProjectFilesService>();
        services.AddSingleton<IDockerProcessService, DockerProcessService>();
    }

    public static void RegisterCodiFileStorage(this IServiceCollection services, IConfiguration configuration)
    {
        ConventionRegistry.Register(nameof(CamelCaseElementNameConvention), new ConventionPack { new CamelCaseElementNameConvention() }, _ => true);
        ConventionRegistry.Register(nameof(IgnoreIfNullConvention), new ConventionPack { new IgnoreIfNullConvention(true) }, _ => true);
        BsonDefaults.GuidRepresentationMode = GuidRepresentationMode.V3;
        BsonSerializer.RegisterSerializer(new GuidSerializer(GuidRepresentation.Standard));

        services.Configure<CodiFileStorageSettings>(configuration.GetSection("FileStorageDatabase"));
        services.AddSingleton<IMongoContext, CodiFileStorageContext>();
        services.AddSingleton<IFileRepository, FileRepository>();
        services.AddSingleton<IProjectRepository, ProjectRepository>();
    }

    public static void RegisterRabbitMQ(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddSingleton<IConnectionFactory>(x => new ConnectionFactory()
        {
            Uri = new Uri(configuration.GetSection("Rabbit").Value)
        });
        services.AddSingleton<IMessageProducerScopeFactory, MessageProducerScopeFactory>();
        services.AddSingleton<IMessageConsumerScopeFactory, MessageConsumerScopeFactory>();

        var projectRunSettings = configuration
            .GetSection("Queues:RunProjectsQueue")
            .Get<MessageScopeSettings>();

        var projectStopSettings = configuration
            .GetSection("Queues:StopProjectsQueue")
            .Get<MessageScopeSettings>();

        var projectInputSettings = configuration
            .GetSection("Queues:ProjectInputQueue")
            .Get<MessageScopeSettings>();

        services.AddSingleton<IBuilderConsumer>(provider =>
            new BuilderConsumer(
                provider.GetRequiredService<IMessageConsumerScopeFactory>(), 
                projectRunSettings,
                projectStopSettings,
                projectInputSettings));

        var projectOutputSettings = configuration
            .GetSection("Queues:ProjectOutputQueue")
            .Get<MessageScopeSettings>();

        services.AddSingleton<IOutputProducer>(provider =>
            new OutputProducer(
                provider.GetRequiredService<IMessageProducerScopeFactory>(),
                projectOutputSettings));
    }
}

