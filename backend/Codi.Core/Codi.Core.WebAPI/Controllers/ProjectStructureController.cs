using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Structure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class ProjectStructureController : Controller
{
    private readonly IProjectStructureService _projectStructureService;

    public ProjectStructureController(IProjectStructureService projectStructureService)
    {
        _projectStructureService = projectStructureService;
    }

    [HttpGet("{projectId}")]
    public async Task<ActionResult<ProjectStructureDto>> GetAsync(long projectId)
    {
        return Ok(await _projectStructureService.GetProjectStructureByIdAsync(projectId));
    }
}