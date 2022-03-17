using AutoMapper;
using Codi.Core.Common.DTO.User;
using Codi.Core.Common.Helpers;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDto>()
                .ForMember(p => p.Avatar, o => o.MapFrom(c => c.Avatar == null ? null : c.Avatar.URL));
            CreateMap<User, UserNameDto>()
                .ForMember(p => p.Avatar, o => o.MapFrom(c => c.Avatar == null ? null : c.Avatar.URL))
                .ForMember(p => p.FullName, o => o.MapFrom(c => $"{c.FirstName} {c.LastName}"));
            CreateMap<UserDto, User>()
                .ForMember(p => p.Avatar, o => o.Ignore());
            CreateMap<CreateUserDto, User>()
                .ForMember(p => p.Email,
                    o => o.MapFrom(c => c.Email ?? ""))
                .ForMember(p => p.UserName,
                    o => o.MapFrom(c => c.Username ?? (c.Email == null ? "" : 
                        UsernameHelper.OmitSpecialCharacters(c.Email.Substring(0, c.Email.IndexOf('@'))))));
        }
    }
}
