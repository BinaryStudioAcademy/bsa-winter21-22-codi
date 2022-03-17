using AutoMapper;
using Codi.Core.Common.DTO.Tag;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.MappingProfiles
{
    public sealed class TagProfile : Profile
    {
        public TagProfile()
        {
            CreateMap<Tag, TagNameDto>();
            CreateMap<Tag, TagInfoDto>();
        }
    }
}
