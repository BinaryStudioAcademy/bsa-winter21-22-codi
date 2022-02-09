namespace Codi.Core.Common.DTO.Project
{
    public class ProjectDto
    {
        public long Id { get; set; }
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsPublic { get; set; }
        public long OwnerId { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
