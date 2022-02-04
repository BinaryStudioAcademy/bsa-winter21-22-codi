using AutoMapper;
using Codi.Core.DAL;

namespace Codi.Core.BL.Services
{
    public abstract class BaseService
    {
        private protected readonly CodiCoreContext _context;
        private protected readonly IMapper _mapper;

        public BaseService(CodiCoreContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
    }
}
