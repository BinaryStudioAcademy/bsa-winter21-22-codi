namespace Codi.Core.Common.DTO.Credentials;

public class AccessTokenCheckDto
{
    public bool IsSucceed { get; set; }
    public string Message { get; set; } = default!;
}