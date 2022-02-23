using Codi.Core.BL.Interfaces;
using Codi.Core.Common.DTO.Organization;
using Codi.Core.WebAPI.Extentions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Authorize]
[Route("[controller]")]
public class OrganizationsController : ControllerBase
{
    private readonly IUserService _userService;
    private readonly IOrganizationService _organizationService;

    public OrganizationsController(IOrganizationService organizationService, IUserService userService)
    {
        _organizationService = organizationService;
        _userService = userService;
    }

    [HttpGet("{organizationId}")]
    public async Task<ActionResult<OrganizationDto>> GetAsync(int organizationId)
    {
        var organization = await _organizationService.GetOrganizationAsync(organizationId);
        return Ok(organization);
    }

    [HttpGet("user/{userId}")]
    public async Task<ActionResult<ICollection<OrganizationDto>>> GetByUserAsync(int userId)
    {
        var organizations = await _organizationService.GetUserOrganizationsAsync(userId);
        return Ok(organizations);
    }

    [HttpPost]
    public async Task<ActionResult<OrganizationDto>> CreateAsync(CreateOrganizationDto organizationDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        organizationDto.OwnerId = (await _userService.GetByFirebaseId(this.GetUserIdFromToken())).Id;
        var organization = await _organizationService.CreateOrganizationAsync(organizationDto);
        return Ok(organization);
    }

    [HttpPut]
    public async Task<ActionResult<OrganizationDto>> UpdateAsync(UpdateOrganizationDto organizationDto)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest();
        }

        organizationDto.OwnerId = (await _userService.GetByFirebaseId(this.GetUserIdFromToken())).Id;
        var organization = await _organizationService.UpdateOrganizationAsync(organizationDto);
        return Ok(organization);
    }

    [HttpDelete("{organizationId}")]
    public async Task<ActionResult> DeleteAsync(int organizationId)
    {
        await _organizationService.DeleteOrganizationAsync(organizationId);
        return NoContent();
    }
}