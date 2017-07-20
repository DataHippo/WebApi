using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class TestDto
    {
        [BsonId]
        public ObjectId Id { get; set; }

        [BsonElement("test_description")]
        public string Description { get; set; }
    }
}
