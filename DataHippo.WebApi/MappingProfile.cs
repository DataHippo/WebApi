using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Entities;

namespace DataHippo.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Test, TestDto>();
            CreateMap<TestDto, Test>();
        }
    }
}
