using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.App
{
    public class NewAppDto
    {
        public long ProjectId { get; set; }
        public string? Image { get; set; }
        public List<long>? Tags { get; set; }

        [JsonIgnore]
        public string? FirebaseId { get; set; }

        [JsonIgnore]
        public long OwnerId { get; set; }
    }
}
