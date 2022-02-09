using AutoMapper;
using Codi.Core.Common.DTO.Thread;
using Thread = Codi.Core.DAL.Entities.Thread;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class ThreadProfile : Profile
    {
        public ThreadProfile()
        {
            CreateMap<Thread, ThreadDto>()
                .ReverseMap();
        }
    }
}
