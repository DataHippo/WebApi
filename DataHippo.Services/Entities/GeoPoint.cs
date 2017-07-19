using System.Collections.Generic;

namespace DataHippo.Services.Entities
{
    public class GeoPoint
    {
        public string Type { get; set; }
        public List<double> Coordinates { get; set; }
    }
}