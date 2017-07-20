using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Driver;

namespace DataHippo.Repositories.Contracts
{
    public interface IMongoDbRepository
    {
        IMongoDatabase Connect();
    }
}
