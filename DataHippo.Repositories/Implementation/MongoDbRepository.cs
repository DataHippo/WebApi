using System;
using System.Runtime.InteropServices;
using DataHippo.Repositories.Contracts;
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
            catch (Exception ex)
            {
                //TODO: Custom Exception
                throw new Exception("Can not access to db server.", ex);
            }

        }
    }
}
