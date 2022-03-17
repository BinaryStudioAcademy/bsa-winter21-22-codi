namespace Codi.Core.Common.DTO.Tag
{
    public class TagInfoDto
    {
        public long Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public int Count { get; set; }
    }
}
