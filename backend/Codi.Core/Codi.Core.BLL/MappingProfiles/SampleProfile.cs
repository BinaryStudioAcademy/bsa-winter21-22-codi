using AutoMapper;
using Codi.Core.Common.DTO;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class SampleProfile : Profile
    {
        public SampleProfile()
        {
            CreateMap<Sample, SampleDto>();
            CreateMap<SampleDto, Sample>();
            CreateMap<NewSampleDto, Sample>();
        }
    }
}
