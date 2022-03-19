using Codi.Core.DAL.NoSql.Entities.Abstract;
using MongoDB.Driver;
using System.Linq.Expressions;


namespace Codi.Core.DAL.NoSql.Repositories.Abstract
{
    public interface IMongoRepository<TDocument> where TDocument : IDocument
    {
        IQueryable<TDocument> AsQueryable();

        Task<List<TDocument>> GetAllAsync(
            Expression<Func<TDocument, bool>> filterExpression);

        Task<List<TNewProject>> GetAllAsync<TNewProject>(
            Expression<Func<TDocument, bool>> filterExpression,
            Expression<Func<TDocument, TNewProject>> projection);

        Task<TDocument> GetByIdAsync(Guid id);
        Task<TNewProject> GetByIdAsync<TNewProject>(Guid id, 
            Expression<Func<TDocument, TNewProject>> projection);

        Task InsertOneAsync(TDocument document);

        Task InsertManyAsync(ICollection<TDocument> documents);

        Task ReplaceOneAsync(TDocument document);

        Task DeleteByIdAsync(Guid id);
    }
}
