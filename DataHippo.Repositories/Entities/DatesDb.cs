using System;
using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class DatesDb
    {
        [BsonElement("revised")]
        public DateTime Revised { get; set; }

        [BsonElement("found")]
        public DateTime Found { get; set; }
    }
}