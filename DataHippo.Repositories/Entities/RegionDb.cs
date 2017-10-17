using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class RegionDb
    {
        [BsonElement("_id")]
        public string Id { get; set; }

        [BsonElement("area")]
        public double Area { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("country")]
        public string Country { get; set; }

        [BsonElement("aptm_total")]
        public int TotalApartments { get; set; }

        [BsonElement("aptm_density")]
        public double ApartementsDensity { get; set; }

        [BsonElement("geojson")]
        public GeoPointDb GeoPoints { get; set; }
    }
}
