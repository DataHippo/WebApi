using DataHippo.Repositories.Contracts;
using DataHippo.Resources;
using DataHippo.Services.Exceptions;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;

namespace DataHippo.Repositories.Implementation
{
    public class MongoDbRepository : IMongoDbRepository
    {
        private readonly IConfiguration _configuration;

        public MongoDbRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IMongoDatabase Connect()
        {

            try
            {
                var databaseConnectionString = _configuration["MongoConnection:ConnectionString"];
                var databaseName = _configuration["MongoConnection:Database"];

                var client = new MongoClient(databaseConnectionString);
                var database = client.GetDatabase(databaseName);
                return database;
            }
            catch
            {
                throw new DataBaseConnectionException(ErrorMessages.DataBaseConnectionException);
            }

        }
    }
}
