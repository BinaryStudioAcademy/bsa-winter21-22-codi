using Codi.Core.Common.DTO.Tag;
using Codi.Core.Common.DTO.User;

namespace Codi.Core.Common.DTO.App
{
    public class AppDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public DateTime CreatedAt { get; set; }
        public UserNameDto Owner { get; set; } = default!;
        public List<TagNameDto> Tags { get; set; } = default!;
    }
}
