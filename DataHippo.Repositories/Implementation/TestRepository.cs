using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Repositories.Contracts;
using DataHippo.Repositories.Entities;

namespace DataHippo.Repositories.Implementation
{
    public class TestRepository : ITestRepository
    {
        public Task<IEnumerable<TestDto>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TestDto> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateAsync(TestDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
