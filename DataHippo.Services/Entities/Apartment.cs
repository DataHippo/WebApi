using System;

namespace DataHippo.Services.Entities
{
    public class Apartment
    {
        public string Id { get; set; }
        public string  UserId { get; set; }
        public Providers Provider { get; set; }
        public string Currency { get; set; }
        public int Price { get; set; }
        public int PriceUsd { get; set; }
        public int Reviews { get; set; }
        public GeoPoint LongLat { get; set; }
        public string Licence { get; set; }
        public DateTime DateInsert { get; set; }
        public DateTime DateLastRevision { get; set; }
        public int Rate { get; set; }
        public int Capacity { get; set; }
        public int MinNights { get; set; }
        public string Url { get; set; }
        public int Rooms { get; set; }
        public int Beds { get; set; }
        public int Bathrooms { get; set; }
        public RoomTypes RoomType { get; set; }
        public string Author { get; set; }

    }
}
