using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace UniversityAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Student, StudentDTO>()
                .ForMember(dist => dist.id, opt => opt.MapFrom(src => src.StudentID))
                .ForMember(dist => dist.Name, opt => opt.MapFrom(src => src.StudentName))
                .ReverseMap();
        }
    }
}
