using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;

namespace DataHippo.Services.Implementation
{   
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;
        private readonly IMapper _mapper;

        public TestService(ITestRepository testRepository, IMapper mapper)
        {
            _testRepository = testRepository;
            _mapper = mapper;
        }

        public Task<IEnumerable<Test>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Test> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateAsync(Test entity)
        {
            
            throw new NotImplementedException();
        }
    }
}
