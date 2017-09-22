using DataHippo.Resources;
using DataHippo.Services.Exceptions;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DataHippo.Repositories
{
    public class MongoDbContext : IMongoDbContext
    {
        private readonly IConfiguration _configuration;

        public MongoDbContext(IConfiguration configuration)
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
