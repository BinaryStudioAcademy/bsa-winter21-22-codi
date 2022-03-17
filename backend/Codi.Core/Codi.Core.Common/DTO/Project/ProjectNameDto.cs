using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.Common.DTO.Project
{
    public class ProjectNameDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = default!;
        public DateTime CreatedAt { get; set; }
    }
}
