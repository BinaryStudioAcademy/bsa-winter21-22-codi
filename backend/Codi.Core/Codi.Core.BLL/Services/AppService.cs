using AutoMapper;
using AutoMapper.QueryableExtensions;
using Codi.Core.BLL.Exceptions;
using Codi.Core.BLL.Extentions;
using Codi.Core.BLL.Interfaces;
using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.App;
using Codi.Core.Common.Enums;
using Codi.Core.DAL;
using Codi.Core.DAL.Entities;
using Codi.Core.DAL.NoSql.Repositories.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Codi.Core.BLL.Services;

public class AppService : BaseService, IAppService
{
    private protected readonly IProjectRepository _projectsRepository;
    private protected readonly IFileRepository _fileRepository;
    private protected readonly IAppRepository _appRepository;

    public AppService(CodiCoreContext context, IMapper mapper, IFileRepository fileRepository,
        IProjectRepository projectsRepository, IAppRepository appRepository) : base(context, mapper)
    {
        _projectsRepository = projectsRepository;
        _fileRepository = fileRepository;
        _appRepository = appRepository;
    }
    public async Task<PaginatedList<AppDto>> GetAllAsync(int pageNumber, int pageSize,
            Expression<Func<App, bool>>? predicate = null,
            Expression<Func<App, object>>? orderBy = null, 
            SortOrder sortOrder = SortOrder.Ascending)
    {
        IQueryable<App> apps = _context.Apps
            .Include(a => a.Owner)
            .ThenInclude(o => o.Avatar)
            .AsNoTracking();

        if (predicate != null)
        {
            apps = apps.Where(predicate);
        }

        if (orderBy != null)
        {
            apps = sortOrder == SortOrder.Descending
                ? apps.OrderByDescending(orderBy)
                : apps.OrderBy(orderBy);
        }

        return await apps
            .ProjectTo<AppDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(pageNumber, pageSize);
    }

    public async Task<PaginatedList<AppDto>> GetAllWithTag(long tagId, int pageNumber, int pageSize,
        Expression<Func<App, object>>? orderBy = null,
        SortOrder sortOrder = SortOrder.Ascending)
    {
        List<long> appIds = await _context.AppTags
            .Where(at => at.TagId == tagId)
            .Select(at => at.AppId)
            .ToListAsync();

        IQueryable<App> apps = _context.Apps
            .Include(a => a.Tags)
            .Include(a => a.Owner)
            .ThenInclude(o => o.Avatar)
            .Where(a => appIds.Contains(a.Id))
            .AsSplitQuery()
            .AsNoTracking();

        if (orderBy != null)
        {
            apps = sortOrder == SortOrder.Descending
                ? apps.OrderByDescending(orderBy)
                : apps.OrderBy(orderBy);
        }

        return await apps
            .ProjectTo<AppDto>(_mapper.ConfigurationProvider)
            .PaginatedListAsync(pageNumber, pageSize);
    }

    public async Task<AppDto> GetByIdAsync(long appId)
    {
        var app = await _context.Apps
            .Where(a => a.Id == appId)
            .ProjectTo<AppDto>(_mapper.ConfigurationProvider)
            .SingleOrDefaultAsync();

        if (app == null)
        {
            throw new NotFoundException(nameof(App), appId);
        }

        return app;
    }

    public async Task<AppDto> CreateAsync(NewAppDto newAppDto)
    {
        var owner = await _context.Users
            .Where(u => u.FirebaseId == newAppDto.FirebaseId)
            .FirstOrDefaultAsync();

        if (owner == null)
        {
            throw new NotFoundException(nameof(User));
        }

        var project = await _context.Projects
            .Where(u => u.Id == newAppDto.ProjectId)
            .FirstOrDefaultAsync();

        if (project == null)
        {
            throw new NotFoundException(nameof(Project), newAppDto.ProjectId);
        }

        List<Tag>? tags = null;
        if(newAppDto.Tags != null)
        {
            tags = await _context.Tags
                .Where(u => newAppDto.Tags.Contains(u.Id))
                .ToListAsync();
        }

        var projectDocument = await _projectsRepository.GetByIdAsync(project.ProjectDocumentId);

        if (projectDocument == null)
        {
            throw new NotFoundException(nameof(projectDocument));
        }

        var appDocument = new DAL.NoSql.Entities.App
        {
            Id = Guid.NewGuid(),
            ProjectId = projectDocument.Id,
            Nodes = await _fileRepository.DublicateFileStructure(projectDocument.Nodes),
        };

        await _appRepository.InsertOneAsync(appDocument);

        var app = _mapper.Map<App>(newAppDto,
            opts => opts.AfterMap((src, dst) =>
            {
                dst.OwnerId = owner.Id;
                dst.CreatedAt = DateTime.Now;
                dst.AppDocumentId = appDocument.Id;
                dst.Name = project.Title;
                dst.Description = project.Description;
                if(tags != null)
                    dst.Tags = tags;
            }));

        var createdApp = _context.Add(app).Entity;
        await _context.SaveChangesAsync();

        return await GetByIdAsync(createdApp.Id);
    }

    public async Task<AppDto> UpdateAsync(long appId, UpdateAppDto newAppDto)
    {
        var existedApp = await _context.Apps
            .Include(a => a.Tags)
            .AsSplitQuery()
            .FirstOrDefaultAsync(s => s.Id == appId);

        if (existedApp == null)
        {
            throw new NotFoundException(nameof(App), appId);
        }

        List<Tag>? tags = null;
        if (newAppDto.Tags != null)
        {
            tags = await _context.Tags
                .Where(u => newAppDto.Tags.Contains(u.Id))
                .ToListAsync();
        }

        var mergedApp = _mapper.Map(newAppDto, existedApp,
            opts => opts.AfterMap((src, dst) =>
            {
                if (tags != null)
                {
                    dst.Tags.Clear();
                    dst.Tags.AddRange(tags);
                }
            }));

        var updatedApp = _context.Update(mergedApp).Entity;
        await _context.SaveChangesAsync();

        return await GetByIdAsync(updatedApp.Id);
    }

    public async Task DeleteAsync(long appId)
    {
        var app = await _context.Apps.FirstOrDefaultAsync(s => s.Id == appId);

        if (app == null)
        {
            throw new NotFoundException(nameof(App), appId);
        }

        var appDocument = await _appRepository.GetByIdAsync(app.AppDocumentId);

        if (appDocument == null)
        {
            throw new NotFoundException(nameof(appDocument));
        }

        await _fileRepository.DeleteFiles(appDocument.Nodes);
        await _appRepository.DeleteByIdAsync(appDocument.Id);

        _context.Remove(app);

        await _context.SaveChangesAsync();
    }
}

