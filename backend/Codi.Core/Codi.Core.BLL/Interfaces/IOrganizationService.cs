using Codi.Core.Common.DTO.Organization;

namespace Codi.Core.BLL.Interfaces;

public interface IOrganizationService
{
    Task<ICollection<OrganizationDto>> GetUserOrganizationsAsync(long userId);
    Task<OrganizationDto> CreateOrganizationAsync(CreateOrganizationDto organizationDto);
    Task<OrganizationDto> GetOrganizationByIdAsync(long id);
    Task<OrganizationDto> UpdateOrganizationAsync(UpdateOrganizationDto organizationDto);
    Task DeleteOrganizationAsync(long id);
}