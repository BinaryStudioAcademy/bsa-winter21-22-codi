using MongoDB.Driver;

namespace Codi.Core.DAL.NoSql.Context.Abstract
{
    public interface IMongoContext
    {
        IMongoClient Client { get; }
        IMongoDatabase Database { get; }
        IMongoCollection<TDocument> GetCollection<TDocument>();
    }
}
