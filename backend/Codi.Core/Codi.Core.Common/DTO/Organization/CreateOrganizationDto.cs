using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Organization;

public class CreateOrganizationDto
{
    public string Name { get; set; } = default!;
    [JsonIgnore]
    public long OwnerId { get; set; }
}