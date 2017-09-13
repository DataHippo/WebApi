using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class UserDb
    {
        [BsonElement("id")]
        public string UserId { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("img")]
        public string Image { get; set; }

        [BsonElement("url")]
        public string Url { get; set; }
    }
}