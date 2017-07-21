using System;
using DataHippo.Repositories.Contracts;
using MongoDB.Driver;

namespace DataHippo.Repositories.Implementation
{
    public class MongoDbRepository :IMongoDbRepository
    {
        public IMongoDatabase Connect()
        {
            try
            {
                var client = new MongoClient("xxx");
                var database = client.GetDatabase("datahippo-dev");
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
