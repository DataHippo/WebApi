using System.Collections.Generic;
using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Entities;

namespace DataHippo.WebApi
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Test, TestDb>();
            CreateMap<TestDb, Test>();
        }
    }
}
