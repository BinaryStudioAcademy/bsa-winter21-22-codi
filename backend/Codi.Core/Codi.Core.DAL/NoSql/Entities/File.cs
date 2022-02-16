using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Entities.Abstract;

namespace Codi.Core.DAL.NoSql.Entities
{
    [BsonCollection("files")]
    public class File : Document
    {
        public string Name { get; set; } = default!;
        public string Content { get; set; } = default!;
    }
}
