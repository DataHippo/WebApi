using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using DataHippo.Repositories.Contracts;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;
using MongoDB.Driver;

namespace DataHippo.Repositories.Implementation
{
    public class TestRepository : ITestRepository
    {
        private readonly IMongoCollection<TestDto> _collection;
        private const string CollectionName = "test_collection";
        private readonly IMapper _mapper;

        public TestRepository(IMapper mapper, IMongoDbRepository repository)
        {
            _mapper = mapper;
            var database = repository.Connect();
            _collection = database.GetCollection<TestDto>(CollectionName);
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
            var dto = _mapper.Map<Test, TestDto>(entity);
            await _collection.InsertOneAsync(dto);
            return _mapper.Map<TestDto, Test>(dto);
        }
    }
}
