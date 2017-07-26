using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;

namespace DataHippo.Services.Implementation
{   
    public class TestService : ITestService
    {
        private readonly ITestRepository _testRepository;

        public TestService(ITestRepository testRepository)
        {
            _testRepository = testRepository;
        }

        public Task<IEnumerable<Test>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Test> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Test> CreateAsync(Test entity)
        {
            //TODO: Validaciones
            return await _testRepository.CreateAsync(entity);
        }
    }
}
