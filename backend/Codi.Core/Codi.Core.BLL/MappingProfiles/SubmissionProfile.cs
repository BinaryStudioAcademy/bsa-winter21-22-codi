using AutoMapper;
using Codi.Core.Common.DTO.Submission;
using Codi.Core.DAL.Entities;

namespace Codi.Core.BL.MappingProfiles
{
    public sealed class SubmissionProfile : Profile
    {
        public SubmissionProfile()
        {
            CreateMap<Submission, SubmissionDto>().ReverseMap();
        }
    }
}
