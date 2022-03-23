using Codi.Core.Common.DTO.Tag;

namespace Codi.Core.BLL.Interfaces
{
    public interface ITagService
    {
        Task<ICollection<TagNameDto>> GetAllAsync();
        Task<TagInfoDto> GetByIdAsync(long tagId);
    }
}
