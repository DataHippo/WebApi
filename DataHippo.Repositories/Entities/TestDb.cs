using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class TestDb
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("test_description")]
        public string Description { get; set; }

        [BsonElement("test_direction")]
        public string Direction { get; set; }
    }
}
