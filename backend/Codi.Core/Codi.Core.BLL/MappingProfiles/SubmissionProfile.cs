using AutoMapper;
using Codi.Core.Common.DTO.Submission;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BLL.MappingProfiles
{
    public sealed class SubmissionProfile : Profile
    {
        public SubmissionProfile()
        {
            CreateMap<Submission, SubmissionDto>().ReverseMap();
        }
    }
}
