using DataHippo.Repositories.Contracts;
using DataHippo.Resources;
using DataHippo.Services.Exceptions;
using MongoDB.Driver;
using Microsoft.Extensions.Configuration;


namespace DataHippo.Repositories.Implementation
{
    public class MongoDbRepository : IMongoDbRepository
    {
        private readonly IConfiguration _config;

        public MongoDbRepository(IConfiguration config)
        {
            _config = config;
        }

        public IMongoDatabase Connect()
        { 

            try
            {
                var databaseConnectionString = _config["MongoConnection:ConnectionString"];
                var databaseName = _config["MongoConnection:Database"];

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
