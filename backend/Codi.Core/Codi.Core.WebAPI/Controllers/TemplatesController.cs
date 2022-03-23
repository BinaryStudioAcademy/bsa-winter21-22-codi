using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Template;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplatesController : ControllerBase
    {
        private readonly ITemplateService _templateService;

        public TemplatesController(ITemplateService templateService)
        {
            _templateService = templateService;
        }

        [HttpGet("names")]
        public async Task<ActionResult<ICollection<TemplateNameDto>>> GetTemplateNames()
        {
            var templates = await _templateService.GetAllTemplateNamesAsync();
            return Ok(templates);
        }
    }
}
