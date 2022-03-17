namespace Codi.Core.Common.DTO.App
{
    public class UpdateAppDto
    {
        public string Name { get; set; } = default!;
        public string? DisplayName { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public List<long>? Tags { get; set; }
    }
}
