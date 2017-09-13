using DataHippo.Services.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace DataHippo.Repositories.Entities
{
    public class ApartmentDb
    {
        [BsonElement("_id")]
        public string Id { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("url")]
        public string Url { get; set; }

        [BsonElement("img")]
        public string Image { get; set; }

        //[BsonElement("provider")]
        //public Providers Provider { get; set; }

        [BsonElement("curr")]
        public string Currency { get; set; }

        [BsonElement("price")]
        public int Price { get; set; }

        [BsonElement("reviews")]
        public int Reviews { get; set; }

        [BsonElement("lnglat")]
        public GeoPointDb LngLat { get; set; }

        [BsonElement("license")]
        public string Licence { get; set; }

        [BsonElement("capacity")]
        public int Capacity { get; set; }

        [BsonElement("min_nights")]
        public int MinNights { get; set; }

        [BsonElement("beds")]
        public int? BedRooms { get; set; }

        [BsonElement("room_type")]
        public string RoomType { get; set; }

        [BsonElement("user")]
        public UserDb User { get; set; }

        [BsonElement("date")]
        public DatesDb Dates { get; set; }

        [BsonElement("country_code")]
        public string CountryCode { get; set; }

        [BsonElement("requires_license")]
        public bool RequiresLicence { get; set; }
    }
}
