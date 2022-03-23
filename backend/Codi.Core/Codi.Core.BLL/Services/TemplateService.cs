using AutoMapper;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Template;
using Codi.Core.DAL;
using Codi.Core.DAL.NoSql.Repositories.Abstract;

namespace Codi.Core.BLL.Services
{
    public class TemplateService : BaseService, ITemplateService
    {
        private protected readonly ITemplateRepository _templateRepository;

        public TemplateService(CodiCoreContext context, IMapper mapper, ITemplateRepository templateRepository) : base(context, mapper)
        {
            _templateRepository = templateRepository;
        }

        public async Task<ICollection<TemplateNameDto>> GetAllTemplateNamesAsync()
        {
            var templates = await _templateRepository.GetAllAsync(_ => true, 
                t => new TemplateNameDto { Id = t.Id, Name = t.Name, Language = t.Language.ToString() });

            return templates;
        }

        public async Task<TemplateNameDto> GetTemplateByIdAsync(Guid templateId)
        {
            var template = await _templateRepository.GetByIdAsync(templateId,
                t => new TemplateNameDto { Id = t.Id, Name = t.Name, Language = t.Language.ToString() });

            return template;
        }
    }
}
