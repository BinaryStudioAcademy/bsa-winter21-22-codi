﻿using AutoMapper;
using Codi.Core.BL.Services;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.Common.DTO.Tag;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.BLL.Services
{
    public class TagService : BaseService, ITagService
    {
        public TagService(CodiCoreContext context, IMapper mapper) : base(context, mapper) { }

        public async Task<ICollection<TagNameDto>> GetAllAsync()
        {
            return await _context.Tags.ProjectToListAsync<TagNameDto>(_mapper.ConfigurationProvider);
        }

        public async Task<TagInfoDto> GetByIdAsync(long tagId)
        {
            var tagEntity = await _context.Tags.FirstOrDefaultAsync(s => s.Id == tagId);

            if (tagEntity is null)
            {
                throw new NotFoundException(nameof(Tag), tagId);
            }

            var tagInfo = _mapper.Map<TagInfoDto>(tagEntity);

            tagInfo.Count = _context.AppTags.Where(at => at.TagId == tagId).Count();

            return tagInfo;
        }
    }
}
