using AutoMapper;
using Codi.Core.BL.Interfaces;
using Codi.Core.BLL.Exceptions;
using Codi.Core.Common.DTO.Organization;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Codi.Core.BL.Services;

public class OrganizationService : BaseService, IOrganizationService
{
    public OrganizationService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

    public async Task<ICollection<OrganizationDto>> GetUserOrganizationsAsync(long userId)
    {
        var organizations = await _context.Organizations
            .Where(o => o.OwnerId == userId)
                .Include(o => o.Courses)
                    .ThenInclude(c => c.CourseUsers)
                        .ThenInclude(cu => cu.User)
                            .ThenInclude(u => u.Avatar)
            .AsSplitQuery()
            .ToListAsync();

        return _mapper.Map<ICollection<OrganizationDto>>(organizations);
    }

    public async Task<OrganizationDto> CreateOrganizationAsync(CreateOrganizationDto organizationDto)
    {
        var organization = _mapper.Map<Organization>(organizationDto, opts => opts.AfterMap((src, dst) =>
        {
            dst.CreatedAt = DateTime.Now;
        }));

        var createdOrganization = _context.Add(organization).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<OrganizationDto>(createdOrganization);
    }

    public async Task<OrganizationDto> GetOrganizationAsync(long id)
    {
        var organization = await _context.Organizations
            .FirstOrDefaultAsync(o => o.Id == id);
        if (organization is null)
        {
            throw new NotFoundException(nameof(Organization), id);
        }
        
        return _mapper.Map<OrganizationDto>(organization);
    }

    public async Task<OrganizationDto> UpdateOrganizationAsync(UpdateOrganizationDto organizationDto)
    {
        var existedOrganization = await _context.Organizations.FirstOrDefaultAsync(o => o.Id == organizationDto.Id);
        
        if (existedOrganization is null || existedOrganization.OwnerId != organizationDto.OwnerId)
        {
            throw new NotFoundException(nameof(Organization), organizationDto.Id);
        }

        var mergedOrganization = _mapper.Map(organizationDto, existedOrganization);

        var updatedOrganization = _context.Update(mergedOrganization).Entity;
        await _context.SaveChangesAsync();

        return _mapper.Map<OrganizationDto>(updatedOrganization);
    }

    public async Task DeleteOrganizationAsync(long id)
    {
        var organization = await _context.Organizations
            .FirstOrDefaultAsync(o => o.Id == id);
        if (organization is null)
        {
            throw new NotFoundException(nameof(Organization), id);
        }
        _context.Remove(organization);

        await _context.SaveChangesAsync();
    }
}