using Codi.Core.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.Common.DTO.Template
{
    public class TemplateNameDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Language { get; set; } = default!;
    }
}
