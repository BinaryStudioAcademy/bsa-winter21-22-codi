using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Codi.Core.Common.DTO.Credentials;

public class AccessTokenDto
{
    public string Token { get; set; } = default!;
    
    [JsonIgnore]
    [IgnoreDataMember]
    public string? FirebaseId { get; set; }

    [JsonIgnore]
    [IgnoreDataMember]
    public long OwnerId { get; set; }
}