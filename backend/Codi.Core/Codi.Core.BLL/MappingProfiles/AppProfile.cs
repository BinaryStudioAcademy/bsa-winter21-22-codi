using AutoMapper;
using Codi.Core.Common.DTO.App;
using Codi.Core.Common.DTO.Project;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class AppProfile : Profile
    {
        public AppProfile()
        {
            CreateMap<App, AppDto>()
                .ForMember(p => p.Image, o => o.MapFrom(c => c.Image == null ? "" : c.Image.URL));
            
            CreateMap<NewAppDto, App>()
                .ForMember(a => a.Tags, src => src.Ignore())
                .ForMember(a => a.Image, 
                    src => src.MapFrom(s => string.IsNullOrEmpty(s.Image) ? null : new Image { URL = s.Image }));

            CreateMap<UpdateAppDto, App>()
                .ForMember(a => a.Image, src => src.Ignore())
                .ForMember(a => a.Tags, src => src.Ignore());
        }
    }
}
