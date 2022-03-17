using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.Common.DTO.User
{
    public class UserNameDto
    {
        public long Id { get; set; }
        public string UserName { get; set; } = default!;
        public string? FullName { get; set; }
        public string? Avatar { get; set; }
    }
}
