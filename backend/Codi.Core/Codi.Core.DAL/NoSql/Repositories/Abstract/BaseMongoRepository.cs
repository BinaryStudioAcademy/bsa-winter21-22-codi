using Codi.Core.DAL.NoSql.Context.Abstract;
using Codi.Core.DAL.NoSql.Entities.Abstract;
using MongoDB.Bson;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public class BaseMongoRepository<TDocument> : IMongoRepository<TDocument>
        where TDocument : IDocument
    {
        protected readonly IMongoContext _context;
        protected IMongoCollection<TDocument> _collection;

        public BaseMongoRepository(IMongoContext context)
        {
            _context = context;
            _collection = context.GetCollection<TDocument>();
        }

        public IQueryable<TDocument> AsQueryable()
        {
            return _collection.AsQueryable();
        }

        public async Task<List<TDocument>> GetAllAsync(Expression<Func<TDocument, bool>> filterExpression)
        {
            return await _collection.Find(filterExpression).ToListAsync();
        }

        public async Task<TDocument> GetByIdAsync(string id)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, new ObjectId(id));
            return await _collection.Find(filter).SingleOrDefaultAsync();
        }

        public async Task InsertOneAsync(TDocument document)
        {
            await _collection.InsertOneAsync(document);
        }

        public async Task InsertManyAsync(ICollection<TDocument> documents)
        {
            await _collection.InsertManyAsync(documents);
        }

        public async Task ReplaceOneAsync(TDocument document)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, document.Id);
            await _collection.FindOneAndReplaceAsync(filter, document);
        }

        public async Task DeleteByIdAsync(string id)
        {
            var filter = Builders<TDocument>.Filter.Eq(doc => doc.Id, new ObjectId(id));
            await _collection.FindOneAndDeleteAsync(filter);
        }
    }
}
