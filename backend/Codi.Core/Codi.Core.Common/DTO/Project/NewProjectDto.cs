using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Project
{
    public class NewProjectDto
    {
        public string Title { get; set; } = default!;
        public string? Description { get; set; }
        public bool IsPublic { get; set; }
        public Guid TemplateId { get; set; }

        [JsonIgnore]
        public string? FirebaseId { get; set; }

        [JsonIgnore]
        public long OwnerId { get; set; }
    }
}
