using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Entities.Abstract;

namespace Codi.Core.DAL.NoSql.Entities
{
    [BsonCollection("templates")]
    public class Template : Document
    {
        public string Name { get; set; } = default!;
        public ICollection<FSNode> Nodes { get; set; } = default!;
    }
}
