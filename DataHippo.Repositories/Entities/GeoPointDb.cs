using System.Collections.Generic;
using DataHippo.Services.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class GeoPointDb
    {
        [BsonElement("type")]
        public GeoPointTypes Type { get; set; }

        [BsonElement("coordinates")]
        public List<double> Coordinates { get; set; }
    }
}