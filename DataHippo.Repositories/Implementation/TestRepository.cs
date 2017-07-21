using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;

namespace DataHippo.Repositories.Implementation
{
    public class TestRepository : ITestRepository
    {
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
