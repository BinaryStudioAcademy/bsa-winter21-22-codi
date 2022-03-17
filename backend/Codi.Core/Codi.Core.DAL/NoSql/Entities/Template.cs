using Codi.Core.Common.Enums;
using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Entities.Abstract;

namespace Codi.Core.DAL.NoSql.Entities
{
    [BsonCollection("templates")]
    public class Template : Document
    {
        public string Name { get; set; } = default!;
        public Language Language { get; set; }
        public ICollection<FSNode> Nodes { get; set; } = default!;
    }
}
