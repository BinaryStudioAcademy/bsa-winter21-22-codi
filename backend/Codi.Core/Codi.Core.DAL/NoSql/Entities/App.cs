using Codi.Core.DAL.NoSql.Attributes;
using Codi.Core.DAL.NoSql.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.DAL.NoSql.Entities
{
    [BsonCollection("apps")]
    public class App : Document
    {
        public Guid ProjectId { get; set; }
        public ICollection<FSNode> Nodes { get; set; } = default!;
    }
}
