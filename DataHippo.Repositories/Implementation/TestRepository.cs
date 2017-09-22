using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataHippo.Repositories.Implementation
{
    public class TestRepository : ITestRepository
    {
        private readonly IMongoCollection<TestDb> _collection;
        private const string CollectionName = "test_collection";
        private readonly IMapper _mapper;

        public TestRepository(IMapper mapper, IMongoDbContext repository)
        {
            _mapper = mapper;
            var database = repository.Connect();
            _collection = database.GetCollection<TestDb>(CollectionName);
        }

        public async Task<IEnumerable<Test>> GetAllAsync(int page, int pageSize, string queryFilter, string fieldsProjection)
        {
            var filter = new BsonDocument();
            var elements = await _collection.Find(filter).Skip(pageSize * (page - 1)).Limit(pageSize).Project<TestDb>(fieldsProjection).ToListAsync();

            return _mapper.Map<List<TestDb>, List<Test>>(elements.ToList());
        }

        public Task<Test> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Test> CreateAsync(Test entity)
        {
            var resutl = _mapper.Map<Test, TestDb>(entity);
            await _collection.InsertOneAsync(resutl);
            return _mapper.Map<TestDb, Test>(resutl);
        }

        public async Task<long> CountAsync()
        {
            var filter = new BsonDocument();
            return await _collection.CountAsync(filter);
        }
    }
}
