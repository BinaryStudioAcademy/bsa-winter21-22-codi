using AutoMapper;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(p => p.Avatar, o => o.MapFrom(c => c.Avatar == null ? "" : c.Avatar.URL));
            CreateMap<UserDto, User>()
                .ForMember(p => p.Avatar, o => o.Ignore());
            CreateMap<CreateUserDto, User>()
                .ForMember(p => p.UserName, o => o.MapFrom(c => c.Email.Substring(0, 10)))
                .ForMember(p => p.CreatedAt, o => o.MapFrom(c => DateTime.Now));
            
        }
    }
}
