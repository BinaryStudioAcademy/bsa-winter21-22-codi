using AutoMapper;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Tag;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BLL.Services
{
    public class TagService : BaseService, ITagService
    {
        public TagService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<TagNameDto>> GetAllAsync()
        {
            return await _context.Tags.ProjectToListAsync<TagNameDto>(_mapper.ConfigurationProvider);
        }

        public async Task<TagInfoDto> GetByIdAsync(long tagId)
        {
            var tagEntity = await _context.Tags.FirstOrDefaultAsync(s => s.Id == tagId);

            if (tagEntity is null)
            {
                throw new NotFoundException(nameof(Tag), tagId);
            }

            var tagInfo = _mapper.Map<TagInfoDto>(tagEntity);

            tagInfo.Count = await _context.AppTags.CountAsync(at => at.TagId == tagId);

            return tagInfo;
        }
    }
}
