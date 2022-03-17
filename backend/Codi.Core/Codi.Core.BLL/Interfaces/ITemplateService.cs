using Codi.Core.Common.DTO.Template;

namespace Codi.Core.BLL.Interfaces
{
    public interface ITemplateService
    {
        Task<ICollection<TemplateNameDto>> GetAllTemplateNamesAsync();
    }
}
