using MongoDB.Driver;

namespace DataHippo.Repositories
{
    public interface IMongoDbContext
    {
        IMongoDatabase Connect();
    }
}
