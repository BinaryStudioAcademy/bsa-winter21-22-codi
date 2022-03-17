using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.Tag;
using Microsoft.AspNetCore.Mvc;

namespace Codi.Core.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagsService;

        public TagsController(ITagService tagsService)
        {
            _tagsService = tagsService;
        }

        [HttpGet]
        public async Task<ActionResult<ICollection<TagNameDto>>> GetAllTags()
        {
            var tags = await _tagsService.GetAllAsync();
            return Ok(tags);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TagInfoDto>> GetTagById(long id)
        {
            return Ok(await _tagsService.GetByIdAsync(id));
        }
    }
}
