namespace DataHippo.Services.Entities
{
    public class Region
    {
        public string Id { get; set; }
        public double Area { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int TotalApartments { get; set; }
        public double ApartementsDensity { get; set; }
        public GeoPoint GeoPoints { get; set; }
    }
}
