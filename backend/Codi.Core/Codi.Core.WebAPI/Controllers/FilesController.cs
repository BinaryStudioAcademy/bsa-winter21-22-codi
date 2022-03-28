using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.File;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class FilesController : Controller
{
    private readonly IFileService _fileService;
    
    public FilesController(IFileService fileService)
    {
        _fileService = fileService;
    }

    [HttpGet("{fileId}")]
    public async Task<ActionResult<FileDto>> GetAsync(Guid fileId)
    {
        return Ok(await _fileService.GetByIdAsync(fileId));
    }
}