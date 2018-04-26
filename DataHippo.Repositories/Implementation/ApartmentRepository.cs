using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataHippo.Repositories.Entities;
using DataHippo.Repositories.Helpers;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataHippo.Repositories.Implementation
{
    public class ApartmentRepository : IApartmentRepository
    {
        private readonly IMongoCollection<ApartmentDb> _collection;
        private const string CollectionName = "apartments";
        private readonly IMapper _mapper;

        public ApartmentRepository(IMapper mapper, IMongoDbContext context)
        {
            _mapper = mapper;
            var database = context.Connect();
            _collection = database.GetCollection<ApartmentDb>(CollectionName);
        }

        public async Task<IEnumerable<Apartment>> GetAllAsync(int page, int pageSize, string fieldsProjection)
        {

            var filter = new BsonDocument();
            var elements = await _collection.Find(filter)
                .Skip(pageSize * (page - 1)).Limit(pageSize)
                .Project<ApartmentDb>(QueryHelper.BuidlFieldsProjectionQuery(fieldsProjection))
                .ToListAsync();
        
            return _mapper.Map<List<ApartmentDb>, List<Apartment>>(elements.ToList());
        }

        public Task<IEnumerable<Apartment>> GetByRegionAsync(int page, int pageSize, string fieldsProjection, string region)
        {
            throw new NotImplementedException("Not implemented yet");
        }

        public async Task<Apartment> GetByIdAsync(string id)
        {
            var filter = new BsonDocument(new BsonElement("_id", id));
            var element = await _collection.Find(filter).SingleAsync();

            return _mapper.Map<ApartmentDb, Apartment>(element);
        }

        public async Task<long> CountAsync()
        {
            var filter = new BsonDocument();
            return await _collection.CountAsync(filter);
        }
    }
}
