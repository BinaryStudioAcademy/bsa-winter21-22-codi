using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Settings;
using Microsoft.Extensions.Options;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using System.Reflection;

namespace Codi.Core.DAL.NoSql.Context
{
    public class CodiFileStorageContext : IMongoContext
    {
        public IMongoClient Client { get; }
        public IMongoDatabase Database { get; }

        public CodiFileStorageContext(IOptions<CodiFileStorageSettings> configuration)
        {
            Client = new MongoClient(configuration.Value.ConnectionString);
            Database = Client.GetDatabase(configuration.Value.DatabaseName);
        }

        public IMongoCollection<TDocument> GetCollection<TDocument>()
        {
            return Database.GetCollection<TDocument>(GetCollectionName<TDocument>());
        }

        protected virtual string GetCollectionName<TDocument>()
        {
            return GetAttributeCollectionName<TDocument>() ??
                throw new InvalidOperationException($"Please declare name of the MongoDB collection associated with type \"{typeof(TDocument).FullName}\" using the BsonCollectionAttribute"); ;
        }

        protected virtual string? GetAttributeCollectionName<TDocument>()
        {
            return (typeof(TDocument).GetTypeInfo()
                                     .GetCustomAttributes(typeof(BsonCollectionAttribute))
                                     .FirstOrDefault() as BsonCollectionAttribute)?.CollectionName;
        }
    }
}
