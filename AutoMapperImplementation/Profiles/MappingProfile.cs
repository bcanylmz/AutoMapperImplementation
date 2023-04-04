using AutoMapper;
using AutoMapperImplementation.DTO;
using AutoMapperImplementation.Entities;

namespace AutoMapperImplementation.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserListDto>().ReverseMap();
        }
    }
}
