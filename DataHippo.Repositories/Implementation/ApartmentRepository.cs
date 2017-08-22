using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DataHippo.Repositories.Contracts;
using DataHippo.Repositories.Entities;
using DataHippo.Services.Contracts;
using DataHippo.Services.Entities;
using DataHippo.Services.Repositories.Contracts;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DataHippo.Repositories.Implementation
{
    public class ApartmentRepository : IApartmentRepository
    {
        private readonly IMongoCollection<ApartmentDb> _collection;
        private const string COLLECTION_NAME = "apartments";
        private readonly IMapper _mapper;

        public ApartmentRepository(IMapper mapper, IMongoDbRepository repository)
        {
            _mapper = mapper;
            var database = repository.Connect();
            _collection = database.GetCollection<ApartmentDb>(COLLECTION_NAME);
        }

        public async Task<IEnumerable<Apartment>> GetAllAsync(string fieldsProjection)
        {
            throw new NotImplementedException();
            //var filter = new BsonDocument();
            //var elements = await _collection.Find(filter)
            //    .Project<ApartmentDb>(QueryHelper.BuidlFieldsProjection(fieldsProjection))
            //    .ToListAsync();

            //return _mapper.Map<List<ApartmentDb>, List<Apartment>>(elements.ToList());
        }

        public async Task<Apartment> GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<Apartment> CreateAsync(Apartment entity)
        {

            throw new NotImplementedException();
        }
    }
}
