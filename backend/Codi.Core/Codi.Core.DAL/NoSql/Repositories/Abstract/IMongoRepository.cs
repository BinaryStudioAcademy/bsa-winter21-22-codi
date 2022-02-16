using Codi.Core.DAL.NoSql.Entities.Abstract;
using System.Linq.Expressions;


namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        IQueryable<TDocument> AsQueryable();

        Task<List<TDocument>> GetAllAsync(
            Expression<Func<TDocument, bool>> filterExpression);

        Task<TDocument> GetByIdAsync(string id);

        Task InsertOneAsync(TDocument document);

        Task InsertManyAsync(ICollection<TDocument> documents);

        Task ReplaceOneAsync(TDocument document);

        Task DeleteByIdAsync(string id);
    }
}
