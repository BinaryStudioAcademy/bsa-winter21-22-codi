using AutoMapper;
using Codi.Core.Common.DTO.Unit;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.MappingProfiles
{
    public sealed class UnitProfile : Profile
    {
        public UnitProfile()
        {
            CreateMap<Unit, UnitDto>();
            CreateMap<CreateUnitDto, Unit>();
        }
    }
}
