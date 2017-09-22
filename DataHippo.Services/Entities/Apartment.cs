namespace DataHippo.Services.Entities
{
    public class Apartment
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Image { get; set; }
        //public Providers Provider { get; set; }
        public string Currency { get; set; }
        public int Price { get; set; }
        public int Reviews { get; set; }
        public GeoPoint LngLat { get; set; }
        public string Licence { get; set; }
        public int Capacity { get; set; }
        public int MinNights { get; set; }      
        public int? BedRooms { get; set; }
        //public RoomTypes RoomType { get; set; }
        public string RoomType { get; set; }
        public User User { get; set; }
        public ApartmentDates Dates { get; set; }
        public string CountryCode { get; set; }
        public bool RequiresLicence { get; set; }

    }
}
