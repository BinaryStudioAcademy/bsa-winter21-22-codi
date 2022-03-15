using AutoMapper;
using Codi.Core.Common.DTO.Organization;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles;

public class OrganizationProfile : Profile
{
    public OrganizationProfile()
    {
        CreateMap<Organization, OrganizationDto>();
        CreateMap<CreateOrganizationDto, Organization>();
        CreateMap<UpdateOrganizationDto, Organization>();
    }
}