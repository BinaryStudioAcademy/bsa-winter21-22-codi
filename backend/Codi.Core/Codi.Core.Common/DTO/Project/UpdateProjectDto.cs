namespace Codi.Core.Common.DTO.Project
{
    public class UpdateProjectDto
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsPublic { get; set; }
    }
}
