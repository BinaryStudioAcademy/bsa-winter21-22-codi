using Codi.Core.BLL.Models;
using Codi.Core.Common.DTO.App;
using Codi.Core.DAL.Entities;
using System.Linq.Expressions;

namespace Codi.Core.BLL.Interfaces
{
    public interface IAppService
    {
        Task<PaginatedList<AppDto>> GetAllAsync(int pageNumber, int pageSize, 
            Expression<Func<App, bool>>? predicate = null, 
            Expression<Func<App, object>>? orderBy = null, bool orderByDesc = false);
        Task<PaginatedList<AppDto>> GetAllWithTag(long tagId, int pageNumber, int pageSize,
        Expression<Func<App, object>>? orderBy = null, bool orderByDesc = false, int? taleNumber = null);
        Task<AppDto> GetByIdAsync(long appId);
        Task<AppDto> CreateAsync(NewAppDto newAppDto);
        Task<AppDto> UpdateAsync(long projectId, UpdateAppDto newAppDto);
        Task DeleteAsync(long appId);
    }
}
