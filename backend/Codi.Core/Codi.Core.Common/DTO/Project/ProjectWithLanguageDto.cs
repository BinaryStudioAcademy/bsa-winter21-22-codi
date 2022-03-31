using Codi.Core.Common.Enums;

namespace Codi.Core.Common.DTO.Project
{
    public class ProjectWithLanguageDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = default!;
        public bool IsPublic { get; set; }
        public DateTime CreatedAt { get; set; }
        public Language? Language { get; set; }
    }
}
