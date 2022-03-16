using Codi.Core.Common.DTO.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codi.Core.BLL.Interfaces
{
    public interface ITagService
    {
        Task<ICollection<TagNameDto>> GetAllAsync();
        Task<TagInfoDto> GetByIdAsync(long tagId);
    }
}
