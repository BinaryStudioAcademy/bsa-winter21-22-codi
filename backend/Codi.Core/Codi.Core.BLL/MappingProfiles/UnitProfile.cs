using AutoMapper;
using Codi.Core.Common.DTO.Unit;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<Unit, UnitDto>()
                .ReverseMap();
        }
    }
}
