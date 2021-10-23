using AutoMapper;
using RegistrationFormAPI.Dtos;
using RegistrationFormAPI.Entities;

namespace RegistrationFormAPI.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegistrationFormDto, QuestionAnswer>();
        }
    }
}
