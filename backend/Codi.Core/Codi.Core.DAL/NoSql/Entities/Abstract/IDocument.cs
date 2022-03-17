using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Codi.Core.DAL.NoSql.Entities.Abstract
{
    public interface IDocument
    {
        [BsonId]
        Guid Id { get; set; }
    }
}
